﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringSilkRoad.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public decimal PreviousPrice { get; set; }

        public int Rating { get; set; }

        public string ImagePath { get; set; }

        public bool FreeShipping { get; set; }

        //Foreign Keys
        public virtual Category Category { get; set; }
    }
}
