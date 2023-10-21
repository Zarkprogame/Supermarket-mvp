﻿using System;
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
        [DisplayName("Category Id")]
        public int Id { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Category Name is Required")]
        [StringLength(50,MinimumLength = 3, ErrorMessage = "Category Name must be between 3 and 50 Characters")]
        public string Name { get; set; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "Category Description is Required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Category Description must be between 3 and 200 Characters")]
        public string Observation { get; set; }
    }
}
