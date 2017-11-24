using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class OwnProduct : BaseResponse
    {
        public int OwnProductId { get; set; }

        [Display(Name = "نوع محصول")]
        public string Kind { get; set; }

        [Display(Name = "نام محصول")]
        public string Name { get; set; }
    }
}
