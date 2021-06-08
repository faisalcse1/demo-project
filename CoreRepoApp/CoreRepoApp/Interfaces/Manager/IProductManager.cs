using EntityFrameworkCore.Repository.Interface.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreRepoApp.Models;


namespace CoreRepoApp.Interfaces.Manager
{
    interface IProductManager:ICommonManager<Product>
    {
        Product GetById(int id);
    }
}
