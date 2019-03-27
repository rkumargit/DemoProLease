using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProLeasingServices.Entities.Models;
using ProLeasingServices.Repository.ProductRepository;

namespace ProLeasingServices.Controllers
{
    [Route("api/[Controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _prodRepo;
        public ProductController(IProductRepository prodRepo)
        {
            _prodRepo = prodRepo;
        }

        public  IList<Product> GetAll()
        {
            IList<Product> prodList = new List<Product>();
            prodList= _prodRepo.GetAllProduct();
            return prodList;
        }
    }
}