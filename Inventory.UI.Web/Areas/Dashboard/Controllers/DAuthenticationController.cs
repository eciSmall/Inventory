using Inventory.Model;
using Inventory.UI.Web.General.Session;
using System.Web.Mvc;

namespace Inventory.UI.Web.Areas.Dashboard.Controllers
{
    public class DAuthenticationController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult ContractMeeting()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckAuthenticate(Partner adminLogin)
        {
            SessionState sessionState = new SessionState();
            sessionState.Store(SessionKeys.AdminSession, "Admin");
            return RedirectToAction("Home", "PartnerArea");
        }
    }
}