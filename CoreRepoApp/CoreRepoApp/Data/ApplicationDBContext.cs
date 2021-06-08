using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreRepoApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CoreRepoApp.Data
{
    public class ApplicationDBContext:IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
