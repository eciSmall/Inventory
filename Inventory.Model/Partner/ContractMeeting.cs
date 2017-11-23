using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class ContractMeeting
    {
        public int ContractMeetingId { get; set; }

        [Display(Name= "خلاصه قرار داد")]
        public string ContactDescription { get; set; }

        [Display(Name = "تعداد جلسات")]
        public int MeetingCount { get; set; }
    }
}
