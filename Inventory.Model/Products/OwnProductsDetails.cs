using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class OwnProductsDetails : BaseResponse
    {
        public int OwnProductsDetailsId { get; set; }

        [Display(Name = "تعداد محصول")]
        public int ProductNumber { get; set; }

        [Display(Name = "مبداء")]
        public string Source { get; set; }

        [Display(Name = "مقصد")]
        public string Destination { get; set; }

        public OwnProduct OwnProduct { get; set; }
    }
}
