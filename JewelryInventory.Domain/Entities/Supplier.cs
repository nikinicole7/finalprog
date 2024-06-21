using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryInventory.Domain.Entities
{
    public class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public string ContactInfo { get; set; }
    }
}

