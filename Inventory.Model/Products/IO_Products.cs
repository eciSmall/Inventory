using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class IO_Products
    {
        public int IO_ProductsId { get; set; }
        public int InvertoryEmployeeRefId { get; set; }
        public int ProductRefId { get; set; }
        public DateTime IncomeDate { get; set; }
        public DateTime OutComeDate { get; set; }
    }
}
