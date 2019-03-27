using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProLeasingServices.Entities.Models;

namespace ProLeasingServices.Repository.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        public IList<Product> GetAllProduct()
        {
            List<Product> ProdList = new List<Product>(){
                new Product(){ ProductId=1,Name="Product1",Description="Newly added",Price=2500.50f,CategoryId=1},
                new Product(){ ProductId=2,Name="Product2",Description="Newly added",Price=1500.50f,CategoryId=1},
                new Product(){ ProductId=3,Name="Product3",Description="Newly added",Price=500.50f,CategoryId=1},
                new Product(){ ProductId=4,Name="Product4",Description="Newly added",Price=25000.50f,CategoryId=2},
                new Product(){ ProductId=5,Name="Product5",Description="Newly added",Price=4500.50f,CategoryId=2}

        };
            return ProdList;
                           
        }
    }
}
