Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.Persistent.BaseImpl.EF.PermissionPolicy

Namespace OData.Server.BusinessObjects

    <DefaultProperty(NameOf(UserName))>
    Public Class ApplicationUser
        Inherits PermissionPolicyUser
        Implements ISecurityUserWithLoginInfo, ISecurityUserLockout

        <Browsable(False)>
        Public Overridable Property AccessFailedCount As Integer

        <Browsable(False)>
        Public Overridable Property LockoutEnd As DateTime

        <Browsable(False)>
        <DevExpress.ExpressApp.DC.Aggregated>
        Public Overridable Property UserLogins As IList(Of ApplicationUserLoginInfo) = New ObservableCollection(Of ApplicationUserLoginInfo)()

        Private ReadOnly Property UserLogins As IEnumerable(Of ISecurityUserLoginInfo)
            Get
                Return Me.UserLogins.OfType(Of ISecurityUserLoginInfo)()
            End Get
        End Property

        Private Function CreateUserLoginInfo(ByVal loginProviderName As String, ByVal providerUserKey As String) As ISecurityUserLoginInfo
            Dim result As ApplicationUserLoginInfo = CType(Me, IObjectSpaceLink).ObjectSpace.CreateObject(Of ApplicationUserLoginInfo)()
            result.LoginProviderName = loginProviderName
            result.ProviderUserKey = providerUserKey
            result.User = Me
            Return result
        End Function
    End Class
End Namespace
