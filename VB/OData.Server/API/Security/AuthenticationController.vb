Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Security.Authentication
Imports DevExpress.ExpressApp.Security.Authentication.ClientServer
Imports Microsoft.AspNetCore.Mvc
Imports Swashbuckle.AspNetCore.Annotations

Namespace OData.Server.JWT

    <ApiController>
    <Route("api/[controller]")>
    ' This is a JWT authentication service sample.
    Public Class AuthenticationController
        Inherits ControllerBase

        Private ReadOnly tokenProvider As IAuthenticationTokenProvider

        Public Sub New(ByVal tokenProvider As IAuthenticationTokenProvider)
            Me.tokenProvider = tokenProvider
        End Sub

        <HttpPost("Authenticate")>
        <SwaggerOperation("Checks if the user with the specified logon parameters exists in the database. If it does, authenticates this user.", "Refer to the following help topic for more information on authentication methods in the XAF Security System: <a href='https://docs.devexpress.com/eXpressAppFramework/119064/data-security-and-safety/security-system/authentication'>Authentication</a>.")>
        Public Function Authenticate(<FromBody> <SwaggerRequestBody("For example: <br /> { ""userName"": ""Admin"", ""password"": """" }")> ByVal logonParameters As AuthenticationStandardLogonParameters) As IActionResult
            Try
                Return Ok(tokenProvider.Authenticate(logonParameters))
            Catch ex As AuthenticationException
                Return Unauthorized(ex.GetJson())
            End Try
        End Function
    End Class
End Namespace
