using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class Partner : BaseResponse
    {
        public int PartnerId { get; set; }

        [Display(Name = "نام شرکت همکار")]
        public string Name { get; set; }

        [Display(Name = "شماره تلفن")]
        public string PhoneNumber { get; set; }

        [Display(Name = "آدرس")]
        public string Address { get; set; }

        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [Display(Name = "پسوورد")]
        public string Password { get; set; }

    }
}
