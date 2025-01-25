Imports System
Imports System.Linq
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Net.Http.Json

Namespace WinForms.Client

    Friend Module ClientSecurity

        Private ReadOnly HttpClient As HttpClient = New HttpClient()

        '
        Private ReadOnly Property BaseUrl As String
            Get
                Return Configuration.ConfigurationManager.AppSettings("baseURL")
            End Get
        End Property

        Private ReadOnly Property AuthUrl As String
            Get
                Return Configuration.ConfigurationManager.AppSettings("authURL")
            End Get
        End Property

        Private ReadOnly Property PermissionUrl As String
            Get
                Return Configuration.ConfigurationManager.AppSettings("checkPermissionURL")
            End Get
        End Property

        Public ReadOnly Property ODataUrl As String
            Get
                Return Configuration.ConfigurationManager.AppSettings("baseODataUrl")
            End Get
        End Property

        '
        Public Sub Initialize()
            HttpClient.BaseAddress = New Uri(BaseUrl)
        End Sub

        Private AuthToken As String

        Public Sub SetAuthToken(ByVal authToken As String)
            ClientSecurity.AuthToken = authToken
        End Sub

        Public Async Function Authenticate(ByVal userName As String, ByVal password As String) As Task(Of String)
            Call HttpClient.DefaultRequestHeaders.Accept.Clear()
            Call HttpClient.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))
            Dim responseMessage = Await HttpClient.PostAsJsonAsync(AuthUrl, New With {userName, password}).ConfigureAwait(False)
            If responseMessage.IsSuccessStatusCode Then
                Dim token As String = Await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(False)
                Return token.Replace("""", "").Trim()
            End If

            Return Nothing
        End Function

        Public Async Function EnsureEditPermissions(ByVal objectTypeFullName As String, ByVal objectKey As String) As Task(Of Boolean)
            Call HttpClient.DefaultRequestHeaders.Accept.Clear()
            Call HttpClient.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))
            HttpClient.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", AuthToken)
            Dim responseMessage = Await HttpClient.GetAsync(PermissionUrl & $"?typeName={objectTypeFullName}&objectKey={objectKey}").ConfigureAwait(False)
            If responseMessage.IsSuccessStatusCode Then
                Dim result As String = Await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(False)
                Return Boolean.Parse(result)
            End If

            Return False
        End Function

        Public Sub EnsureAuthorization(ByVal args As Microsoft.OData.Client.BuildingRequestEventArgs)
            args.Headers.Add("Authorization", "Bearer " & AuthToken) ' Add authentification token
        End Sub
    End Module
End Namespace
