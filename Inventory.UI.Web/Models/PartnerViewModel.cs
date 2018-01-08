using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.UI.Web.Models
{
    public class PartnerViewModel
    {
        public List<Partner> PartnersList { get; set; }
        public Partner PartnerModel { get; set; }
        public ContractMeeting ContractMeeting { get; set; }
        public PartnerContract PartnerContract { get; set; }
        public PartnerRequest PartnerRequest { get; set; }
        public List<PartnerRequest> PartnerRequestList { get; set; }
    }
}