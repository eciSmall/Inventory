using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class ProductModel : BaseResponse
    {
        public int ProductModelId { get; set; }

        [Display(Name = "نام محصول")]
        public string Name { get; set; }

        [Display(Name = "تاریخ انقضاء")]
        public DateTime Expiration { get; set; }

        [Display(Name = "تاریخ تولید")]
        public DateTime Opening { get; set; }

        [Display(Name = "تعداد محصول")]
        public int ProductNumber { get; set; }

        [Display(Name = "مبداء")]
        public string Source { get; set; }

        [Display(Name = "مقصد")]
        public string Destination { get; set; }

        [Display(Name = "قیمت")]
        public string Price  { get; set; }

        [Display(Name = "انبار مربوط")]
        public int InventoryId { get; set; }
    }
}
