using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class ProductModel
    {
        [DisplayName("Product Id")]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product Name is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product Name must be between 3 and 50 Characters")]
        public string Name { get; set; }

        [DisplayName("Product Price")]
        public int Price { get; set; }

        [DisplayName("Product Stock")]
        public int Stock { get; set; }

        [DisplayName("Category Id")]
        public int CategoryId { get; set; }
    }
}
