﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
   public class OrderDetail:BaseEntity
    {
        public int ProductID { get; set; }
        public int OrderID { get; set; }

        public decimal?  TotalPrice { get; set; }


        // relational properties

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

    }
}