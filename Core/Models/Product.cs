﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public double Price { get; set; }

        public int CategoryId { get; set; }

        Category Category { get; set; }

    }
}
