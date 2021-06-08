using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoRepo.Manager;
using MongoRepoApp.Interfaces.Manager;
using MongoRepoApp.Models;
using MongoRepoApp.Repository;

namespace MongoRepoApp.Manager
{
    public class CategoryManager:CommonManager<Category>,ICategoryManager
    {
        public CategoryManager():base(new CategoryRepository())
        {
            
        }
    }
}
