Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.EF
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.SystemModule
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl.EF
Imports DevExpress.Persistent.BaseImpl.EF.PermissionPolicy
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.Extensions.DependencyInjection
Imports OData.Server.BusinessObjects

Namespace OData.Server.DatabaseUpdate

    ' For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
    Public Class Updater
        Inherits ModuleUpdater

        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub

        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            'string name = "MyName";
            'EntityObject1 theObject = ObjectSpace.FirstOrDefault<EntityObject1>(u => u.Name == name);
            'if(theObject == null) {
            '    theObject = ObjectSpace.CreateObject<EntityObject1>();
            '    theObject.Name = name;
            '}
            ' The code below creates users and roles for testing purposes only.
            ' In production code, you can create users and assign roles to them automatically, as described in the following help topic:
            ' https://docs.devexpress.com/eXpressAppFramework/119064/data-security-and-safety/security-system/authentication
#If Not RELEASE
            ' If a role doesn't exist in the database, create this role
            Dim defaultRole = CreateDefaultRole()
            Dim adminRole = CreateAdminRole()
            ObjectSpace.CommitChanges() 'This line persists created object(s).
            Dim userManager As UserManager = ObjectSpace.ServiceProvider.GetRequiredService(Of UserManager)()
            ' If a user named 'User' doesn't exist in the database, create this user
            If userManager.FindUserByName(Of ApplicationUser)(ObjectSpace, "User") Is Nothing Then
                ' Set a password if the standard authentication type is used
                Dim EmptyPassword As String = "QQQ"
                __ = userManager.CreateUser(Of ApplicationUser)(ObjectSpace, "User", EmptyPassword, Function(user)
                    ' Add the Users role to the user
                    user.Roles.Add(defaultRole)
                End Function)
            End If

            ' If a user named 'Admin' doesn't exist in the database, create this user
            If userManager.FindUserByName(Of ApplicationUser)(ObjectSpace, "Admin") Is Nothing Then
                ' Set a password if the standard authentication type is used
                Dim EmptyPassword As String = "QQQ"
                __ = userManager.CreateUser(Of ApplicationUser)(ObjectSpace, "Admin", EmptyPassword, Function(user)
                    ' Add the Administrators role to the user
                    user.Roles.Add(adminRole)
                End Function)
            End If

            ObjectSpace.CommitChanges() 'This line persists created object(s).
#End If
            If ObjectSpace.FirstOrDefault(Of OrderItem)(Function(n) True) Is Nothing Then
                For Each orderItem As OrderItem In OrderItem.GetInitialData()
                    Dim oi = ObjectSpace.CreateObject(Of OrderItem)()
                    oi.ProductName = orderItem.ProductName
                    oi.Quantity = orderItem.Quantity
                    oi.UnitPrice = orderItem.UnitPrice
                    oi.OrderDate = orderItem.OrderDate
                Next

                ObjectSpace.CommitChanges() 'This line persists created object(s).
            End If
        End Sub

        Public Overrides Sub UpdateDatabaseBeforeUpdateSchema()
            MyBase.UpdateDatabaseBeforeUpdateSchema()
        End Sub

        Private Function CreateAdminRole() As PermissionPolicyRole
            Dim adminRole As PermissionPolicyRole = ObjectSpace.FirstOrDefault(Of PermissionPolicyRole)(Function(r) r.Name Is "Administrators")
            If adminRole Is Nothing Then
                adminRole = ObjectSpace.CreateObject(Of PermissionPolicyRole)()
                adminRole.Name = "Administrators"
                adminRole.IsAdministrative = True
            End If

            Return adminRole
        End Function

        Private Function CreateDefaultRole() As PermissionPolicyRole
            Dim defaultRole As PermissionPolicyRole = ObjectSpace.FirstOrDefault(Of PermissionPolicyRole)(Function(role) role.Name Is "Default")
            If defaultRole Is Nothing Then
                defaultRole = ObjectSpace.CreateObject(Of PermissionPolicyRole)()
                defaultRole.Name = "Default"
                defaultRole.AddObjectPermissionFromLambda(Of ApplicationUser)(SecurityOperations.Read, Function(cm) cm.ID Is CType(CurrentUserIdOperator.CurrentUserId(), Guid), SecurityPermissionState.Allow)
                defaultRole.AddNavigationPermission("Application/NavigationItems/Items/Default/Items/MyDetails", SecurityPermissionState.Allow)
                defaultRole.AddMemberPermissionFromLambda(Of ApplicationUser)(SecurityOperations.Write, "ChangePasswordOnFirstLogon", Function(cm) cm.ID Is CType(CurrentUserIdOperator.CurrentUserId(), Guid), SecurityPermissionState.Allow)
                defaultRole.AddMemberPermissionFromLambda(Of ApplicationUser)(SecurityOperations.Write, "StoredPassword", Function(cm) cm.ID Is CType(CurrentUserIdOperator.CurrentUserId(), Guid), SecurityPermissionState.Allow)
                defaultRole.AddTypePermissionsRecursively(Of PermissionPolicyRole)(SecurityOperations.Read, SecurityPermissionState.Allow)
                defaultRole.AddObjectPermissionFromLambda(Of OrderItem)(SecurityOperations.ReadOnlyAccess, Function(oi) True, SecurityPermissionState.Allow)
            End If

            Return defaultRole
        End Function
    End Class
End Namespace
