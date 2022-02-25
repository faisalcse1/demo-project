using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6WithSqliteExample.Models
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=D:\My Tutorials\demo-project\Dot Net 6\DotNet6WithSqliteExample\DB\UniversityDB.db");
        }

        public DbSet<Student> Students { get; set; }
    }
}
