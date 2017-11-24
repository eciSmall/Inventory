using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class InvertoryEmployee : Employee
    {
        public int InvertoryEmployeeId { get; set; }
        public string Kind { get; set; }
    }
}
