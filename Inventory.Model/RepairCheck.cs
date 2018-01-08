using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class RepairCheck
    {
        public int RepairCheckId { get; set; }

        [Display(Name ="تاریخ بررسی")]
        public DateTime VisitDate { get; set; }

        [Display(Name = "قیمت پیشنهادی")]
        public int SugesstionPrice { get; set; }

        [Display(Name = "نیازمند تعمیر")]
        public bool NeedRepair { get; set; }
        public int InventoryRefId { get; set; }
    }
}
