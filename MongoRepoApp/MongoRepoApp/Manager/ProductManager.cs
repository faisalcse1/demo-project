using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoRepo.Manager;
using MongoRepo.Repository;
using MongoRepoApp.Interfaces.Manager;
using MongoRepoApp.Models;
using MongoRepoApp.Repository;

namespace MongoRepoApp.Manager
{
    public class ProductManager : CommonManager<Product>, IProductManager
    {
        public ProductManager() : base(new ProductRepository())
        {
        }

        public bool IsExist(string name)
        {
            var product = GetFirstOrDefault(c => c.ItemName.ToLower() == name.ToLower());
            if(product!=null)
            {
                return true;
            }

            return false;
        }
    }
}
