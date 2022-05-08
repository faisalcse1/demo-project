using DotNet6ApiDemo.Models;
using Microsoft.EntityFrameworkCore;
namespace DotNet6ApiDemo.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
    }
}
