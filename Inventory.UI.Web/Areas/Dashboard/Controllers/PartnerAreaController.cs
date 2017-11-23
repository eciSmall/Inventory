using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.UI.Web.Areas.Dashboard.Controllers
{
    public class PartnerAreaController : BaseDashboardController
    {
        public ActionResult PartnerCop()
        {
            return View();
        }
        public ActionResult PartnerCopList()
        {
            return View();
        }

        public ActionResult PartnerContract()
        {
            PartnerViewModel = new Models.PartnerViewModel();
            PartnerViewModel.PartnerContract = new Model.PartnerContract()
            {
                ContractAmount = 123333,
                ContractDate = DateTime.Now,
                EndDate = DateTime.Now,
                StartDate = DateTime.Now,
                PaymentStatus = true
            };
            return View(PartnerViewModel);
        }
        public ActionResult ContractMeeting()
        {
            PartnerViewModel = new Models.PartnerViewModel();
            PartnerViewModel.ContractMeeting = new Model.ContractMeeting()
            {
                ContactDescription = "...این قرار داد به منظور",
                MeetingCount = 3,
            };
            return View(PartnerViewModel);
        }
        public ActionResult PartnerRequest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PartnerRequest(Model.PartnerRequest partnerRequest)
        {
            PartnerViewModel = new Models.PartnerViewModel();
            PartnerViewModel.PartnerRequest = new Model.PartnerRequest()
            {
                RequestDescription = "تعدادی محصول جدید ...",
                RequestKind = "درخواست فضای در ساعات غیر عادی"
            };
            PartnerViewModel.PartnerRequest.EndUserMessage = "با موفقیت اضافه شد";
            return View(PartnerViewModel);
        }
    }
}