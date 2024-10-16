Imports DevExpress.ExpressApp.Design
Imports DevExpress.ExpressApp.EFCore.DesignTime
Imports DevExpress.ExpressApp.EFCore.Updating
Imports DevExpress.Persistent.BaseImpl.EF
Imports DevExpress.Persistent.BaseImpl.EF.PermissionPolicy
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Design

Namespace OData.Server.BusinessObjects

    ' This code allows our Model Editor to get relevant EF Core metadata at design time.
    ' For details, please refer to https://supportcenter.devexpress.com/ticket/details/t933891.
    Public Class FreeWebApiSecurityContextInitializer
        Inherits DbContextTypesInfoInitializerBase

        Protected Overrides Function CreateDbContext() As DbContext
            Dim optionsBuilder = New DbContextOptionsBuilder(Of FreeWebApiSecurityEFCoreDbContext)().UseSqlServer(";").UseChangeTrackingProxies().UseObjectSpaceLinkProxies()
            Return New FreeWebApiSecurityEFCoreDbContext(optionsBuilder.Options)
        End Function
    End Class

    'This factory creates DbContext for design-time services. For example, it is required for database migration.
    Public Class FreeWebApiSecurityDesignTimeDbContextFactory
        Inherits IDesignTimeDbContextFactory(Of FreeWebApiSecurityEFCoreDbContext)

        Public Function CreateDbContext(ByVal args As String()) As FreeWebApiSecurityEFCoreDbContext
            'throw new InvalidOperationException("Make sure that the database connection string and connection provider are correct. After that, uncomment the code below and remove this exception.");
            Dim optionsBuilder = New DbContextOptionsBuilder(Of FreeWebApiSecurityEFCoreDbContext)()
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Data Source=(localdb)\mssqllocaldb;Initial Catalog=FreeWebApiSecurity")
            optionsBuilder.UseChangeTrackingProxies()
            optionsBuilder.UseObjectSpaceLinkProxies()
            Return New FreeWebApiSecurityEFCoreDbContext(optionsBuilder.Options)
        End Function
    End Class

    <TypesInfoInitializer(GetType(FreeWebApiSecurityContextInitializer))>
    Public Class FreeWebApiSecurityEFCoreDbContext
        Inherits DbContext

        Public Sub New(ByVal options As DbContextOptions(Of FreeWebApiSecurityEFCoreDbContext))
            MyBase.New(options)
        'this.Database.EnsureDeleted();
        'this.Database.EnsureCreated();
        End Sub

        Public Property Roles As DbSet(Of PermissionPolicyRole)

        Public Property Users As DbSet(Of ApplicationUser)

        Public Property UserLoginInfos As DbSet(Of ApplicationUserLoginInfo)

        Public Property OrderItems As DbSet(Of OrderItem)

        Protected Overrides Sub OnModelCreating(ByVal modelBuilder As ModelBuilder)
            MyBase.OnModelCreating(modelBuilder)
            modelBuilder.HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangingAndChangedNotificationsWithOriginalValues)
            modelBuilder.UsePropertyAccessMode(PropertyAccessMode.PreferFieldDuringConstruction)
            modelBuilder.Entity(Of ApplicationUserLoginInfo)(Function(b)
                b.HasIndex(NameOf(DevExpress.ExpressApp.Security.ISecurityUserLoginInfo.LoginProviderName), NameOf(DevExpress.ExpressApp.Security.ISecurityUserLoginInfo.ProviderUserKey)).IsUnique()
            End Function)
        End Sub
    End Class
End Namespace
