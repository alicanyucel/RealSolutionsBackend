﻿using NTierArchitecture.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Entities.Models
{
    public class Customer:Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string CustomerCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
       public List<Order> Orders { get; set; }
    }
}
