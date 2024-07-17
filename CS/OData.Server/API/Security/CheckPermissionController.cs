using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Core;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.Authentication.ClientServer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace OData.Server.JWT;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class CheckPermissionController : ControllerBase {
    readonly IAuthenticationTokenProvider tokenProvider;
    private readonly SecurityStrategy _security;
    private readonly IObjectSpaceFactory _securedObjectSpaceFactory;
    readonly ITypesInfo _typesInfo;

    public CheckPermissionController(ISecurityStrategyBase security, IObjectSpaceFactory securedObjectSpaceFactory, ITypesInfo typesInfo) {
        _security = (SecurityStrategy)security;
        _securedObjectSpaceFactory = securedObjectSpaceFactory;
        _typesInfo = typesInfo;
    }
    [HttpGet(nameof(CanEdit))]
    public IActionResult CanEdit(string typeName, string objectKey) {
        var type = _typesInfo.FindTypeInfo(typeName)?.Type;
        using(var objectSpace = _securedObjectSpaceFactory.CreateObjectSpace(type)) {
            var key = objectSpace.GetObjectKey(type, objectKey);
            return Ok(_security.CanWrite(type, objectSpace, key));
        }
    }
}

