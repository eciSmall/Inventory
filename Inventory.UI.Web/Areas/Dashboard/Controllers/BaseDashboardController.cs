using Inventory.Model;
using Inventory.UI.Web.General;
using Inventory.UI.Web.Models;
using System.Web.Mvc;

namespace Inventory.UI.Web.Areas.Dashboard.Controllers
{
    public class BaseDashboardController : Controller
    {
        protected APIService<CPanelAPIControllers> apiCaller = new APIService<CPanelAPIControllers>();
        protected PartnerViewModel PartnerViewModel;
    }
}