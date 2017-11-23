using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class PartnerContract
    {
        public int ContractId { get; set; }

        [Display(Name = "تاریخ شروع")]
        public DateTime StartDate { get; set; }

        [Display(Name = "تاریخ خاتمه")]
        public DateTime EndDate { get; set; }

        [Display(Name = "تاریخ اخذ قرار داد")]
        public DateTime ContractDate { get; set; }

        [Display(Name = "مقدار قرار داد")]
        public int ContractAmount { get; set; }

        [Display(Name = "وضعیت پرداخت")]
        public bool PaymentStatus { get; set; }
    }
}
