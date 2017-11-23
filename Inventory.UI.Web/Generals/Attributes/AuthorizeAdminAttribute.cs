using Inventory.UI.Web.General.Session;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Inventory.UI.Web.General.Attributes
{
    public class AuthorizeAdminAttribute : AuthorizeAttribute
    {
        SessionState SessionState = new SessionState();
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (SessionState.Get(SessionKeys.AdminSession) == null)
            {
                filterContext.Result = new RedirectToRouteResult(new
                RouteValueDictionary(new { area = "CPanel", controller = "CPAuthentication", action = "Login" }));
            }
        }
    }
}