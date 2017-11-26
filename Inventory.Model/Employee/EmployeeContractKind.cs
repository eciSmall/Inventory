using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class EmployeeContractKind : BaseResponse
    {
        public int EmployeeContractKindId { get; set; }
        public string ContractKind { get; set; }
    }
}
