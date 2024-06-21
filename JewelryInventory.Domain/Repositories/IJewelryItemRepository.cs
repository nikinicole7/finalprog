using JewelryInventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryInventory.Domain.Repositories
{
    public interface IJewelryItemRepository : IBaseRepository<JewelryItem>
    {
        // Métodos adicionales específicos para JewelryItem
    }
}
