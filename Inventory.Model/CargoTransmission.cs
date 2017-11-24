using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class CargoTransmission
    {
        public int CargoTransmissionId { get; set; }

        [Display(Name = "مبداء")]
        public string Origin { get; set; }

        [Display(Name = "مقصد")]
        public string Destination { get; set; }
    }
}
