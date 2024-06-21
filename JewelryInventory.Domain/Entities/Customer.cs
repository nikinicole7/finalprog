using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryInventory.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string ContactInfo { get; set; }
    }
}

