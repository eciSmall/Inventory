using Inventory.UI.Web.General.Attributes;
using Inventory.UI.Web.General.Session;
using Inventory.UI.Web.Models;
using Invertory.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.UI.Web.Areas.Dashboard.Controllers
{
    public class PartnerAreaController : BaseDashboardController
    {
        PartnerLogic partnerLogic = new PartnerLogic();
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult PartnerCopP()
        {
            SessionState sessionState = new SessionState();
            int partnerId = (int)sessionState.Get(SessionKeys.PartnerSession);
            var requestResult = partnerLogic.GetPartner(partnerId);
            PartnerViewModel = new Models.PartnerViewModel()
            {
                PartnerModel = requestResult
            };
            return View("PartnerCop", PartnerViewModel);
        }
        public ActionResult PartnerCop(int partnerId)
        {
            var requestResult = partnerLogic.GetPartner(partnerId);
            PartnerViewModel = new Models.PartnerViewModel()
            {
                PartnerModel = requestResult
            };
            return View(PartnerViewModel);
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
            SessionState sessionState = new SessionState();
            partnerRequest.PartnerRefId = (int)sessionState.Get(SessionKeys.PartnerSession);
            var requestResult = partnerLogic.AddPartnerRequest(partnerRequest);
            PartnerViewModel = new Models.PartnerViewModel();
            PartnerViewModel.PartnerRequest = new Model.PartnerRequest()
            {
                EndUserMessage = requestResult.EndUserMessage
            };
            return View(PartnerViewModel);
        }
        public ActionResult PartnerRequestList()
        {
            SessionState sessionState = new SessionState();
            int partnerId = (int)sessionState.Get(SessionKeys.PartnerSession);
            PartnerViewModel = new PartnerViewModel();
            PartnerViewModel.PartnerRequestList = partnerLogic.PartnerRquestListByPartner(partnerId);
            return View(PartnerViewModel);
        }
    }
}