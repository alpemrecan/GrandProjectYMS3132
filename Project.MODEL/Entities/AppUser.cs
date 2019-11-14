﻿using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
   public class AppUser:BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public Guid? ActivateionCode { get; set; }

        public UserRole Role { get; set; }

        public AppUser()
        {
            Role = UserRole.Member;
            ActivateionCode = Guid.NewGuid();
        }

        // relational properties

        public virtual AppUserDetail Profile { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}