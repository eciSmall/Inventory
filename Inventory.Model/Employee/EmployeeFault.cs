using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class EmployeeFault : BaseResponse
    {
        public int EmployeeFaultId { get; set; }

        [Display(Name = "تعداد خطا")]
        public int FaultNumber { get; set; }

        [Display(Name = "تاریخچه کاهش حقوق")]
        public int SalaryReductionHiostory { get; set; }

        [Display(Name = "شناسه کارمند")]
        public int EmployeeId { get; set; }
    }
}
