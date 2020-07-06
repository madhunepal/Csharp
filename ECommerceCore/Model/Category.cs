﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name="Category Name")]
        public String Name { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        public int DisplayOrder { get; set; }
    }
}
