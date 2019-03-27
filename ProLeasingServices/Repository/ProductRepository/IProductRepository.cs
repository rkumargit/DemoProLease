using ProLeasingServices.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProLeasingServices.Repository.ProductRepository
{
    public interface IProductRepository
    {
        IList<Product> GetAllProduct();
    }
}
