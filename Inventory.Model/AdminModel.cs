using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class AdminModel : BaseResponse
    {
        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [Display(Name = "پسوورد")]
        public string Password { get; set; }

    }
}
