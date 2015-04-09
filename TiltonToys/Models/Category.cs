﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TiltonToys.Models
{
    /* This class represents the type of product that the application is 
     * designed to sell (such as "Cars", "Boats", "Rockets", and so on)
     */
    public class Category
    {
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Product Description")]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}