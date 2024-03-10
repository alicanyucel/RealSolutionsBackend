using NTierArchitecture.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Entities.Models
{
    public class Repo:Entity
    {
       
        public int Quantity { get; set; }
        public bool isSalesReady { get; set; }
    }
}
