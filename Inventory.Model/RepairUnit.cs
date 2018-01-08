using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class RepairUnit : BaseResponse
    {
        public int RepairUnitId { get; set; }

        [Display(Name = "نام")]
        public String Name { get; set; }

        [Display(Name = "شماره تلفن")]
        public string PhoneNumber { get; set; }
    }
}
