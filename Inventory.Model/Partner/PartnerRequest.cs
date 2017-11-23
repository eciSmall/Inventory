using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class PartnerRequest : BaseResponse
    {
        public int PartnerRequestId { get; set; }

        [Display(Name = "موضوع درخواست")]
        public string RequestKind { get; set; }

        [Display(Name = "متن درخواست")]
        public string RequestDescription { get; set; }
    }
}
