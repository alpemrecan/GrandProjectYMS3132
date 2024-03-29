﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Category : BaseEntity
    {

        public Category()
        {
            Products = new List<ProductCategory>();
        }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        // Relational Properties

        public virtual List<ProductCategory> Products { get; set; }
    }
}
