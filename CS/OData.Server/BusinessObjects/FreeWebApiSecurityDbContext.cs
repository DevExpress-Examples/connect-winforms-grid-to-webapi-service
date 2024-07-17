using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EFCore.DesignTime;
using DevExpress.ExpressApp.EFCore.Updating;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace OData.Server.BusinessObjects;

// This code allows our Model Editor to get relevant EF Core metadata at design time.
// For details, please refer to https://supportcenter.devexpress.com/ticket/details/t933891.
public class FreeWebApiSecurityContextInitializer : DbContextTypesInfoInitializerBase {
    protected override DbContext CreateDbContext() {
        var optionsBuilder = new DbContextOptionsBuilder<FreeWebApiSecurityEFCoreDbContext>()
            .UseSqlServer(";")
            .UseChangeTrackingProxies()
            .UseObjectSpaceLinkProxies();
        return new FreeWebApiSecurityEFCoreDbContext(optionsBuilder.Options);
    }
}
//This factory creates DbContext for design-time services. For example, it is required for database migration.
public class FreeWebApiSecurityDesignTimeDbContextFactory : IDesignTimeDbContextFactory<FreeWebApiSecurityEFCoreDbContext> {
    public FreeWebApiSecurityEFCoreDbContext CreateDbContext(string[] args) {
        //throw new InvalidOperationException("Make sure that the database connection string and connection provider are correct. After that, uncomment the code below and remove this exception.");
        var optionsBuilder = new DbContextOptionsBuilder<FreeWebApiSecurityEFCoreDbContext>();
        optionsBuilder.UseSqlServer("Integrated Security=SSPI;Data Source=(localdb)\\mssqllocaldb;Initial Catalog=FreeWebApiSecurity");
        optionsBuilder.UseChangeTrackingProxies();
        optionsBuilder.UseObjectSpaceLinkProxies();
        return new FreeWebApiSecurityEFCoreDbContext(optionsBuilder.Options);
    }
}
[TypesInfoInitializer(typeof(FreeWebApiSecurityContextInitializer))]
public class FreeWebApiSecurityEFCoreDbContext : DbContext {
    public FreeWebApiSecurityEFCoreDbContext(DbContextOptions<FreeWebApiSecurityEFCoreDbContext> options) : base(options) {
        //this.Database.EnsureDeleted();
        //this.Database.EnsureCreated();
    }
    public DbSet<PermissionPolicyRole> Roles { get; set; }
    public DbSet<OData.Server.BusinessObjects.ApplicationUser> Users { get; set; }
    public DbSet<OData.Server.BusinessObjects.ApplicationUserLoginInfo> UserLoginInfos { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangingAndChangedNotificationsWithOriginalValues);
        modelBuilder.UsePropertyAccessMode(PropertyAccessMode.PreferFieldDuringConstruction);
        modelBuilder.Entity<OData.Server.BusinessObjects.ApplicationUserLoginInfo>(b => {
            b.HasIndex(nameof(DevExpress.ExpressApp.Security.ISecurityUserLoginInfo.LoginProviderName), nameof(DevExpress.ExpressApp.Security.ISecurityUserLoginInfo.ProviderUserKey)).IsUnique();
        });
    }
}
