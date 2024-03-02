using NTierArchitecture.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Entities.Models
{
    public class Repo:Entity
    {
        public Product ProductId { get; set; }
        public int Quantity { get; set; }
        public bool isSalesReady { get; set; }
    }
}
