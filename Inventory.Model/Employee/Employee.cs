using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class Employee : BaseResponse
    {
        public int EmployeeId { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        public string Name { get; set; }

        [Display(Name = "شماره شناسنامه")]
        public int PersonalId { get; set; }

        [Display(Name = "کد ملی")]
        public int NationalId { get; set; }

        [Display(Name = "محل تولد")]
        public string BirthPlace { get; set; }

        [Display(Name = "تاریخ تولد")]
        public DateTime? BirthDay { get; set; }

        [Display(Name = "شماره تلفن")]
        public string PhoneNumber { get; set; }

        [Display(Name = "آدرس")]
        public string Address { get; set; }
    }
}
