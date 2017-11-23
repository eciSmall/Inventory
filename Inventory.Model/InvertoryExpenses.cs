using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class InvertoryExpenses : BaseResponse
    {
        public int InvertoryExpensesId { get; set; }

        [Display(Name="درآمد")]
        public int InvertoryIncome { get; set; }

        [Display(Name = "مالیات")]
        public int Tax { get; set; }

        [Display(Name = "سال مربوط")]
        public DateTime Year { get; set; }

        [Display(Name = "مخارج")]
        public int Outcome { get; set; }
    }
}
