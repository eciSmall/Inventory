using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model.Products
{
    public class IO_OwnProducts
    {
        public int IO_ProductsId { get; set; }
        public InvertoryEmployee InvertoryEmployee { get; set; }
        public OwnProduct OwnProduct { get; set; }
        public DateTime IncomeDate { get; set; }
        public DateTime OutComeDate { get; set; }
    }
}
