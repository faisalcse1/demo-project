using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoRepo.Interfaces.Manager;
using MongoRepoApp.Models;

namespace MongoRepoApp.Interfaces.Manager
{
    interface IProductManager:ICommonManager<Product>
    {
        bool IsExist(string name);
    }
}
