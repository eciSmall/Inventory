using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class Inventory
    {
        public int InventoryId { get; set; }

        [Display(Name = "نام")]
        public string Name { get; set; }

        [Display(Name = "شماره تلفن")]
        public string PhoneNumber { get; set; }

        [Display(Name = "ادرس")]
        public string Address { get; set; }

        [Display(Name = "استان")]
        public string State { get; set; }

        [Display(Name = "شهر")]
        public string City { get; set; }

        [Display(Name = "وضعیت تعمیر")]
        public bool RepairCondition { get; set; }

        [Display(Name = "زیر بنا")]
        public int Foundation { get; set; }

        [Display(Name = "نمایندگی")]
        public bool Representation { get; set; }
    }
}
