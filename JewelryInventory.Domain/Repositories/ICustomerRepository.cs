using JewelryInventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryInventory.Domain.Repositories
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        // Métodos adicionales específicos para Customer
    }
}

