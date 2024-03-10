using NTierArchitecture.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Entities.Models
{
    public sealed class Order:Entity
    {

       
       public Customer Customer { get; set; }
    public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
