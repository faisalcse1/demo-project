using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreRepoApp.Data;
using CoreRepoApp.Interfaces.Repository;
using CoreRepoApp.Models;
using EntityFrameworkCore.Repository.Repository;
using Microsoft.EntityFrameworkCore;

namespace CoreRepoApp.Repository
{
    public class ProductRepository : CommonRepository<Product>, IProductRepository
    {
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
