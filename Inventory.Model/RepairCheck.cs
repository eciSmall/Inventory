using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class RepairCheck
    {
        public int RepairCheckId { get; set; }
        public DateTime VisitDate { get; set; }
        public int SugesstionPrice { get; set; }
    }
}
