using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class Lorry : BaseResponse
    {
        public int LorryId { get; set; }

        [Display(Name = "پلاک")]
        public string Plate { get; set; }

        [Display(Name = "نوع")]
        public string LorryKind { get; set; }
    }
}
