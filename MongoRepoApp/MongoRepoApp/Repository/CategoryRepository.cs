using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoRepo.Context;
using MongoRepo.Repository;
using MongoRepoApp.Database;
using MongoRepoApp.Interfaces.Repository;
using MongoRepoApp.Models;

namespace MongoRepoApp.Repository
{
    public class CategoryRepository:CommonRepository<Category>,ICategoryRepository
    {
        public CategoryRepository():base(new ApplicationDbContext(DbConnection.ConnectionString,DbConnection.DBName))
        {
            
        }
    }
}
