using DotNet6ApiDemo.Models;
using EF.Core.Repository.Interface.Repository;

namespace DotNet6ApiDemo.Interfaces.Repository
{
    public interface IPostRepository:ICommonRepository<Post>
    {
    }
}
