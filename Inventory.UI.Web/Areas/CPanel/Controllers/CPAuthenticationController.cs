using Inventory.Model;
using Inventory.UI.Web.General.Attributes;
using Inventory.UI.Web.General.Session;
using System.Net.Http;
using System.Web.Mvc;

namespace Inventory.UI.Web.Areas.CPanel.Controllers
{
    public class CPAuthenticationController : BaseCPanelController
    {
        public ActionResult Login(AdminModel adminLogin)
        {
            if (SessionState.Get(SessionKeys.AdminSession) == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Home", "CPParking");
            }
        }

        [AuthorizeAdmin]
        [HttpGet]
        public ActionResult CheckAuthenticate()
        {
            return RedirectToAction("Home", "CPParking");
        }

        [HttpPost]
        public ActionResult CheckAuthenticate(AdminModel adminLogin)
        {
            //var result = apiCaller.Call<AdminModel, AdminModel>(Model.Web.CPanelAPIControllers.CPAuthentication, "Login", HttpMethod.Post, new AdminModel()
            //{
            //    Email = adminLogin.Email,
            //    Password = adminLogin.Password
            //});
            var result = new AdminModel();
            if (result.Status == Model.ResponseStatus.Success)
            {
                SessionState.Store(SessionKeys.AdminSession, adminLogin.Email);
                return View("Home");
            }
            else
            {
                AdminModel adminLoginResponse = new AdminModel();
                adminLoginResponse.Status = result.Status;
                if (result.EndUserMessage != null)
                {
                    adminLoginResponse.EndUserMessage = result.EndUserMessage;
                }
                else
                {
                    adminLoginResponse.EndUserMessage = "Api Connection Problem!";
                }
                return View("Login",  adminLoginResponse);
            }
        }
    }
}