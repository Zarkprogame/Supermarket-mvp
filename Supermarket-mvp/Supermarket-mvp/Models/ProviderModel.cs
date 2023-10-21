using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class ProviderModel
    {
        [DisplayName("Provider Nit")]
        public int Nit { get; set; }

        [DisplayName("Provider Name")]
        [Required(ErrorMessage = "Provider Name is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Provider Name must be between 3 and 50 Characters")]
        public string Name { get; set; }

        [DisplayName("Provider Address")]
        [Required(ErrorMessage = "Provider Addres is Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Provider Addres must be between 3 and 100 Characters")]
        public string Address { get; set; }

        [DisplayName("Provider Number")]
        [Required(ErrorMessage = "Provider Number is Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Provider Number must be between 3 and 100 Characters")]
        public string Number { get; set; }
    }
}
