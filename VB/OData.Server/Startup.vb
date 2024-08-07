Imports System.Text
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.ApplicationBuilder
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Security.Authentication.ClientServer
Imports DevExpress.ExpressApp.WebApi.Services
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl.EF.PermissionPolicy
Imports Microsoft.AspNetCore.Authentication.JwtBearer
Imports Microsoft.AspNetCore.Authorization
Imports Microsoft.AspNetCore.OData
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.IdentityModel.Tokens
Imports Microsoft.OpenApi.Models
Imports OData.Server.BusinessObjects

Namespace OData.Server

    Public Class Startup

        Public Sub New(ByVal configuration As IConfiguration)
            Me.Configuration = configuration
        End Sub

        Public ReadOnly Property Configuration As IConfiguration

        ' This method gets called by the runtime. Use this method to add services to the container.
        ' For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        Public Sub ConfigureServices(ByVal services As IServiceCollection)
            services.AddScoped(Of IAuthenticationTokenProvider, JwtTokenProviderService)()
            services.AddXafWebApi(Function(builder)
                builder.ConfigureOptions(Function(options)
                    ' Make your business objects available in the Web API and generate the GET, POST, PUT, and DELETE HTTP methods for it.
                    options.BusinessObject(Of OrderItem)()
                End Function)
                builder.Modules.Add(Of FreeWebApiSecurityModule)()
                builder.ObjectSpaceProviders.AddSecuredEFCore(Function(options) options.PreFetchReferenceProperties()).WithDbContext(Of FreeWebApiSecurityEFCoreDbContext)(Function(serviceProvider, options)
                    ' Uncomment this code to use an in-memory database. This database is recreated each time the server starts. With the in-memory database, you don't need to make a migration when the data model is changed.
                    ' Do not use this code in production environment to avoid data loss.
                    ' We recommend that you refer to the following help topic before you use an in-memory database: https://docs.microsoft.com/en-us/ef/core/testing/in-memory
                    'options.UseInMemoryDatabase("InMemory");
                    Dim connectionString As String = Nothing
                    If Configuration.GetConnectionString("ConnectionString") IsNot Nothing Then
                        connectionString = Configuration.GetConnectionString("ConnectionString")
                    End If

                    ArgumentNullException.ThrowIfNull(connectionString)
                    options.UseSqlServer(connectionString)
                    options.UseChangeTrackingProxies()
                    options.UseObjectSpaceLinkProxies()
                    options.UseXafServiceProviderContainer(serviceProvider)
                    options.UseLazyLoadingProxies()
                End Function).AddNonPersistent()
                builder.Security.UseIntegratedMode(Function(options)
                    options.Lockout.Enabled = True
                    options.RoleType = GetType(PermissionPolicyRole)
                    ' ApplicationUser descends from PermissionPolicyUser and supports the OAuth authentication. For more information, refer to the following topic: https://docs.devexpress.com/eXpressAppFramework/402197
                    ' If your application uses PermissionPolicyUser or a custom user type, set the UserType property as follows:
                    options.UserType = GetType(ApplicationUser)
                    ' ApplicationUserLoginInfo is only necessary for applications that use the ApplicationUser user type.
                    ' If you use PermissionPolicyUser or a custom user type, comment out the following line:
                    options.UserLoginInfoType = GetType(ApplicationUserLoginInfo)
                    options.Events.OnSecurityStrategyCreated += Function(securityStrategy)
                        CType(securityStrategy, SecurityStrategy).PermissionsReloadMode = PermissionsReloadMode.CacheOnFirstAccess
                    End Function
                End Function).AddPasswordAuthentication(Function(options)
                    options.IsSupportChangePassword = True
                End Function)
                builder.AddBuildStep(Function(application)
                    application.ApplicationName = "SetupApplication.FreeWebApiSecurity"
                    application.CheckCompatibilityType = DevExpress.ExpressApp.CheckCompatibilityType.DatabaseSchema
#If DEBUG
                    If System.Diagnostics.Debugger.IsAttached AndAlso application.CheckCompatibilityType Is CheckCompatibilityType.DatabaseSchema Then
                        application.DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways
                        application.DatabaseVersionMismatch += Function(s, e)
                            e.Updater.Update()
                            e.Handled = True
                        End Function
                    End If
#End If
                End Function)
            End Function, Configuration)
            services.AddControllers().AddOData(Function(options, serviceProvider)
                options.AddRouteComponents("api/odata", New EdmModelBuilder(serviceProvider).GetEdmModel()).EnableQueryFeatures()
            End Function)
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(Function(options)
                'ValidIssuer = Configuration["Authentication:Jwt:Issuer"],
                'ValidAudience = Configuration["Authentication:Jwt:Audience"],
                options.TokenValidationParameters = New TokenValidationParameters() With {.ValidateIssuerSigningKey = True, .ValidateIssuer = False, .ValidateAudience = False, .IssuerSigningKey = New SymmetricSecurityKey(Encoding.UTF8.GetBytes(Me.Configuration("Authentication:Jwt:IssuerSigningKey")))}
            End Function)
            services.AddAuthorization(Function(options)
                options.DefaultPolicy = New AuthorizationPolicyBuilder(JwtBearerDefaults.AuthenticationScheme).RequireAuthenticatedUser().RequireXafAuthentication().Build()
            End Function)
            services.AddSwaggerGen(Function(c)
                c.EnableAnnotations()
                c.SwaggerDoc("v1", New OpenApiInfo With {.Title = "FreeWebApiSecurity API", .Version = "v1", .Description = "Use AddXafWebApi(options) in the OData.Server\Startup.cs file to make Business Objects available in the Web API."})
                c.AddSecurityDefinition("JWT", New OpenApiSecurityScheme() With {.Type = SecuritySchemeType.Http, .Name = "Bearer", .Scheme = "bearer", .BearerFormat = "JWT", .[In] = ParameterLocation.Header})
                c.AddSecurityRequirement(New OpenApiSecurityRequirement() From {{New OpenApiSecurityScheme() With {.Reference = New OpenApiReference() With {.Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme, .Id = "JWT"}}, New String(-1) {}}})
            End Function)
            services.Configure(Of Microsoft.AspNetCore.Mvc.JsonOptions)(Function(o)
                'The code below specifies that the naming of properties in an object serialized to JSON must always exactly match
                'the property names within the corresponding CLR type so that the property names are displayed correctly in the Swagger UI.
                'XPO is case-sensitive and requires this setting so that the example request data displayed by Swagger is always valid.
                'Comment this code out to revert to the default behavior.
                'See the following article for more information: https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializeroptions.propertynamingpolicy
                o.JsonSerializerOptions.PropertyNamingPolicy = Nothing
            End Function)
        End Sub

        ' This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        Public Sub Configure(ByVal app As IApplicationBuilder, ByVal env As IWebHostEnvironment)
            If env.IsDevelopment() Then
                app.UseDeveloperExceptionPage()
                app.UseSwagger()
                app.UseSwaggerUI(Function(c)
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "FreeWebApiSecurity WebApi v1")
                End Function)
            Else
                app.UseExceptionHandler("/Error")
                ' The default HSTS value is 30 days. To change this for production scenarios, see: https://aka.ms/aspnetcore-hsts.
                app.UseHsts()
            End If

            app.UseHttpsRedirection()
            app.UseRequestLocalization()
            app.UseStaticFiles()
            app.UseRouting()
            app.UseAuthentication()
            app.UseAuthorization()
            app.UseEndpoints(Function(endpoints)
                endpoints.MapControllers()
                endpoints.MapXafEndpoints()
            End Function)
        End Sub
    End Class
End Namespace
