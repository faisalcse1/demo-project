using DotNet6ApiDemo.Context;
using DotNet6ApiDemo.Interfaces.Repository;
using DotNet6ApiDemo.Models;
using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;

namespace DotNet6ApiDemo.Repository
{
    public class PostRepository : CommonRepository<Post>, IPostRepository
    {
        public PostRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
