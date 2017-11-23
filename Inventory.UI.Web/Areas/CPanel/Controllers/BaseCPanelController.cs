using Inventory.Model;
using Inventory.UI.Web.General;
using Inventory.UI.Web.General.Session;
using Inventory.UI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.UI.Web.Areas.CPanel.Controllers
{
    public class BaseCPanelController : Controller
    {
        protected APIService<CPanelAPIControllers> apiCaller = new APIService<CPanelAPIControllers>();
        protected SessionState SessionState = new SessionState();
        protected Model.Inventory InventoryModel;
        protected InvertoryViewModel InvertoryViewModel;
        protected PartnerViewModel PartnerViewModel;
    }
}