using System.Web.Mvc;

namespace Inventory.UI.Web.Areas.Dashboard.Controllers
{
    public class DAuthenticationController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
    }
}