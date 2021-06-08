using Microsoft.AspNetCore.Mvc;
using MongoRepoApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MongoRepoApp.Interfaces.Manager;
using MongoRepoApp.Manager;

namespace MongoRepoApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductManager _productManager=new ProductManager();
        ICategoryManager _categoryManager=new CategoryManager();

        public IActionResult Index()
        {
            var products = _productManager.GetAll();
            return View(products);
        }
        public ActionResult Create()
        {
            ViewBag.Categories = _categoryManager.GetAll();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product,IFormFile Image)
        {
            ViewBag.Categories = _categoryManager.GetAll();
            product.Id = Guid.NewGuid().ToString();
            bool isExist = _productManager.IsExist(product.ItemName);
            if(isExist)
            {
                ViewBag.Mgs = "Product already exist.";
                return View(product);
            }

            var category = _categoryManager.GetById(product.CategoryId);
            product.Category = category;

            if(Image!=null)
            {
                MemoryStream memoryStream=new MemoryStream();
                Image.OpenReadStream().CopyTo(memoryStream);
                product.Image = Convert.ToBase64String(memoryStream.ToArray());
            }
            else
            {
                product.Image = "";
            }
            bool isSaved= _productManager.Add(product);
            string mgs = "";
            if (isSaved)
            {
                return RedirectToAction("Index");
            }
            else
            {
                mgs = "Save failed.";
            }

            ViewBag.Mgs = mgs;
            return View();
        }

        public ActionResult Edit(string id)
        {
            ViewBag.Categories = _categoryManager.GetAll();
            var product = _productManager.GetById(id);
            if(product==null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product, IFormFile Image)
        {
            ViewBag.Categories = _categoryManager.GetAll();
            var category = _categoryManager.GetById(product.CategoryId);
            product.Category = category;

            if (Image != null)
            {
                MemoryStream memoryStream = new MemoryStream();
                Image.OpenReadStream().CopyTo(memoryStream);
                product.Image = Convert.ToBase64String(memoryStream.ToArray());
            }
            else
            {
                product.Image = "";
            }
            bool isUpdated =_productManager.Update(product.Id, product);
           if(isUpdated)
           {
               return RedirectToAction("Index");
           }

           return View(product);
        }

        public ActionResult Details(string id)
        {
            var product = _productManager.GetById(id);
            if(product==null)
            {
                return NotFound();
            }
            return View(product);
        }

        public ActionResult Delete(string id)
        {
            var product = _productManager.GetById(id);
            if(product==null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {
            bool isDelete= _productManager.Delete(product.Id);
            if(isDelete)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Mgs = "Product delete failed.";
            return View(product);
        }
    }
}
