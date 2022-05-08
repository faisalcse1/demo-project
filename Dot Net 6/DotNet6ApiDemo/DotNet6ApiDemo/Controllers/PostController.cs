using CoreApiResponse;
using DotNet6ApiDemo.Context;
using DotNet6ApiDemo.Interfaces.Manager;
using DotNet6ApiDemo.Manager;
using DotNet6ApiDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DotNet6ApiDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostController : BaseController
    {
        //ApplicationDbContext _dbContext;
        IPostManager _postManager;
        //public PostController(ApplicationDbContext dbContext)
        //{
        //    _dbContext = dbContext;
            
        //}

        public PostController(IPostManager postManager)
        {
            _postManager = postManager;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                //var posts = _dbContext.Posts.ToList();
                var posts = _postManager.GetAll().OrderBy(c=>c.CreatedDate).ThenBy(c=>c.Title).ToList();
                return CustomResult("Data loaded successfully",posts);
            }
            catch(Exception ex)
            {
                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }
            
        }

        [HttpGet("title")]
        public IActionResult GetAll(string title)
        {
            try
            {
                var posts = _postManager.GetAll(title);
                return CustomResult("Data loaded done.",posts.ToList());
            }
            catch(Exception exception)
            {
                return CustomResult(exception.Message, HttpStatusCode.BadRequest);
            }
        }

        [HttpGet("text")]
        public IActionResult SearchPost(string text)
        {
            try
            {
                var posts = _postManager.SearchPost(text);
                return CustomResult("Searching result", posts);
            }
            catch (Exception exception)
            {
                return CustomResult(exception.Message, HttpStatusCode.BadRequest);
            }
        }

        [HttpGet]
        public IActionResult GetPosts(int page=1)
        {
            try
            {
                var posts = _postManager.GetPosts(page, 10);
                return CustomResult("Paging data for page no "+page,posts.ToList());
            }
            catch (Exception exception)
            {
                return CustomResult(exception.Message, HttpStatusCode.BadRequest);
            }
        }

        [HttpGet]
        public IActionResult GetAllDesc()
        {
            try
            {
                var posts=_postManager.GetAll().OrderByDescending(c=>c.CreatedDate).ThenByDescending(c=>c.Title).ToList();
                return CustomResult("Data loaded successfully.", posts);
            }
            catch (Exception ex)
            {
                return CustomResult(ex.Message,HttpStatusCode.BadRequest);
            }
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            try
            {
                var post = _postManager.GetById(id);
                if (post == null)
                {
                    return CustomResult("Data not found",HttpStatusCode.NotFound);
                }
                return CustomResult("Data found",post);
            }
            catch (Exception ex)
            {
                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }
            
        }

        [HttpPost]
        public IActionResult Add(Post post)
        {
            try
            {
                post.CreatedDate = DateTime.Now;
                bool isSaved = _postManager.Add(post);
                //_dbContext.Posts.Add(post);
                //bool isSaved = _dbContext.SaveChanges() > 0;
                if (isSaved)
                {
                    //return Created("", post);
                    return CustomResult("Post has been created.",post);
                }
                return CustomResult("Post save failed.",HttpStatusCode.BadRequest);
            }
            catch(Exception ex)
            {
                return CustomResult(ex.Message,HttpStatusCode.BadRequest);
            }
            
        }

        [HttpPut]
        public IActionResult Edit(Post post)
        {
            try
            {
                if (post.Id == 0)
                {
                    return CustomResult("Id is missing.", HttpStatusCode.BadRequest);
                }
                bool isUpdate = _postManager.Update(post);
                if (isUpdate)
                {
                    return CustomResult("Post updated done.",post);
                }
                return CustomResult("Post updated failed.",HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }
            
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            try
            {
                var post = _postManager.GetById(id);
                if (post == null)
                {
                    return CustomResult("Data not found",HttpStatusCode.NotFound);
                }
                bool isDelete = _postManager.Delete(post);
                if (isDelete)
                {
                    return CustomResult("Post has been deleted.");
                }
                return CustomResult("Post deletd failed.", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }
            
        }
    }
}
