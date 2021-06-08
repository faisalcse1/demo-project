using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("DefaultConnection")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}