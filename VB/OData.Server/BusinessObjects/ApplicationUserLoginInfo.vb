Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Runtime.CompilerServices
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.ConditionalAppearance
Imports DevExpress.ExpressApp.Security

Namespace OData.Server.BusinessObjects

    <Table("PermissionPolicyUserLoginInfo")>
    Public Class ApplicationUserLoginInfo
        Inherits ISecurityUserLoginInfo

        Public Sub New()
        End Sub

        <Browsable(False)>
        Public Overridable Property ID As Guid

        <Appearance("PasswordProvider", Enabled:=False, Criteria:="!(IsNewObject(this)) and LoginProviderName == '" & SecurityDefaults.PasswordAuthentication & "'", Context:="DetailView")>
        Public Overridable Property LoginProviderName As String

        <Appearance("PasswordProviderUserKey", Enabled:=False, Criteria:="!(IsNewObject(this)) and LoginProviderName == '" & SecurityDefaults.PasswordAuthentication & "'", Context:="DetailView")>
        Public Overridable Property ProviderUserKey As String

        <Browsable(False)>
        Public Overridable Property UserForeignKey As Guid

        <Required>
        <ForeignKey(NameOf(ApplicationUserLoginInfo.UserForeignKey))>
        Public Overridable Property User As ApplicationUser

        Private ReadOnly Property User As Object
            Get
                Return Me.User
            End Get
        End Property
    End Class
End Namespace
