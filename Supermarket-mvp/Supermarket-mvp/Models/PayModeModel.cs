using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class PayModeModel
    {
        [DisplayName("Pay Mode Id")]
        public int Id { get; set; }

        [DisplayName("Pay Mode Name")]
        [Required(ErrorMessage = "Pay Mode Name is Required")]
        [StringLength(50,MinimumLength = 3, ErrorMessage = "Pay Mode Name must be between 3 and 50 Characters")]
        public string Name { get; set; }

        [DisplayName("Obseration")]
        [Required(ErrorMessage = "Pay Mode Description is Required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Pay Mode Observation must be between 3 and 200 Characters")]
        public string Observation { get; set; }
    }
}
