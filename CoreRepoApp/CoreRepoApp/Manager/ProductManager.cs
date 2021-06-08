using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreRepoApp.Data;
using CoreRepoApp.Interfaces.Manager;
using CoreRepoApp.Models;
using CoreRepoApp.Repository;
using EntityFrameworkCore.Repository.Manager;

namespace CoreRepoApp.Manager
{
    public class ProductManager:CommonManager<Product>,IProductManager
    {
        public ProductManager(ApplicationDBContext dbContext):base(new ProductRepository(dbContext))
        {
            
        }

        public Product GetById(int id)
        {
            return GetFirstOrDefault(c => c.Id == id);
        }
    }
}
