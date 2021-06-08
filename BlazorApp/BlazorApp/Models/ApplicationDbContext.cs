using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ADMINRG-3NFFO9N;Database=BlazorDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Product> Products { get; set; }
    }
}
