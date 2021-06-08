using Microsoft.AspNetCore.Mvc;
using MongoRepoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoRepoApp.Interfaces.Manager;
using MongoRepoApp.Manager;

namespace MongoRepoApp.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryManager _categoryManager=new CategoryManager();
        public IActionResult Index()
        {
            var categories = _categoryManager.GetAll();
            return View(categories);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
           category.Id = Guid.NewGuid().ToString();
           bool isSaved= _categoryManager.Add(category);
           string mgs = "";
           if(isSaved)
           {
               mgs = "Category has been saved.";
           }
           else
           {
               mgs = "Category saved failed.";
           }

           ViewBag.Mgs = mgs;
           return View();
        }
    }
}
