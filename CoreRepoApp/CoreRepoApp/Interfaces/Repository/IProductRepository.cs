using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreRepoApp.Models;
using EntityFrameworkCore.Repository.Interface.Repository;

namespace CoreRepoApp.Interfaces.Repository
{
    interface IProductRepository:ICommonRepository<Product>
    {
    }
}
