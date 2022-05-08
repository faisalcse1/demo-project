using DotNet6ApiDemo.Models;
using EF.Core.Repository.Interface.Manager;

namespace DotNet6ApiDemo.Interfaces.Manager
{
    public interface IPostManager:ICommonManager<Post>
    {
        Post GetById(int id);
        ICollection<Post> GetAll(string title);
        ICollection<Post> SearchPost(string text);
        ICollection<Post> GetPosts(int page,int pageSize);
    }
}
