using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class IOProducts
    {
        public int IOProductsId { get; set; }
        public InvertoryEmployee InvertoryEmployee { get; set; }
        public ProductModel Product { get; set; }
        public IncomeProducts IncomeProduct { get; set; }
        public OutcomeProducts OutcomeProduct { get; set; }
    }
}
