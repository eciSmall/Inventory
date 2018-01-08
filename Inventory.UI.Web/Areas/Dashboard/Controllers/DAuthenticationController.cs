using Inventory.Model;
using Inventory.UI.Web.General.Session;
using Invertory.Business;
using System.Web.Mvc;

namespace Inventory.UI.Web.Areas.Dashboard.Controllers
{
    public class DAuthenticationController : Controller
    {
        PartnerLogic partnerLogic = new PartnerLogic();
        public ActionResult Login(Partner partner)
        {
            return View(partner);
        }
        public ActionResult ContractMeeting()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckAuthenticate(Partner partner)
        {
            int partnerId;
            var requestResult = partnerLogic.Login(partner, out partnerId);
            if(requestResult.Status != ResponseStatus.Success)
            {
                return RedirectToAction("Login", "DAuthentication", new Partner(){  EndUserMessage = "نام کاربری یا پسوورد اشتباه می‌باشد" } );
            }
            SessionState sessionState = new SessionState();
            sessionState.Store(SessionKeys.PartnerSession, partnerId);
            return RedirectToAction("Home", "PartnerArea");
        }
    }
}