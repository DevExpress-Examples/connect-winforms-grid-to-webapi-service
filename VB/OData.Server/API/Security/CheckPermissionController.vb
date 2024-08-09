Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Core
Imports DevExpress.ExpressApp.DC
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Security.Authentication.ClientServer
Imports Microsoft.AspNetCore.Authorization
Imports Microsoft.AspNetCore.Mvc
Imports Swashbuckle.AspNetCore.Annotations

Namespace OData.Server.JWT

    <Authorize>
    <ApiController>
    <Route("api/[controller]")>
    Public Class CheckPermissionController
        Inherits ControllerBase

        Private ReadOnly tokenProvider As IAuthenticationTokenProvider

        Private ReadOnly _security As SecurityStrategy

        Private ReadOnly _securedObjectSpaceFactory As IObjectSpaceFactory

        Private ReadOnly _typesInfo As ITypesInfo

        Public Sub New(ByVal security As ISecurityStrategyBase, ByVal securedObjectSpaceFactory As IObjectSpaceFactory, ByVal typesInfo As ITypesInfo)
            _security = CType(security, SecurityStrategy)
            _securedObjectSpaceFactory = securedObjectSpaceFactory
            _typesInfo = typesInfo
        End Sub

        <HttpGet(NameOf(CanEdit))>
        Public Function CanEdit(ByVal typeName As String, ByVal objectKey As String) As IActionResult
            Dim type = _typesInfo.FindTypeInfo(typeName)?.Type
            Using objectSpace = _securedObjectSpaceFactory.CreateObjectSpace(type)
                Dim key = objectSpace.GetObjectKey(type, objectKey)
                Return Ok(_security.CanWrite(type, objectSpace, key))
            End Using
        End Function
    End Class
End Namespace
