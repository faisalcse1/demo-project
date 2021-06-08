using CoreRepoApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreRepoApp.Data;
using CoreRepoApp.Interfaces.Manager;
using CoreRepoApp.Manager;

namespace CoreRepoApp.Controllers
{
    public class ProductController : Controller
    {
        private ProductManager _productManager;
        public ProductController(ProductManager productManager)
        {
            _productManager=productManager;
        }
        public IActionResult Index()
        {
            var products = _productManager.GetAll();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            string mgs = "";
            bool isSaved= _productManager.Add(product);
            if(isSaved)
            {
                return RedirectToAction("Index");
            }
            else
            {
                mgs = "Product save failed.";
            }

            ViewBag.Mgs = mgs;
            return View();
        }

        public ActionResult Edit(int id)
        {
            var product =_productManager.GetById(id);
            if(product==null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            bool isUpdated = _productManager.Update(product);
            if(isUpdated)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public ActionResult Details(int id)
        {
            var product = _productManager.GetById(id);
            if(product==null)
            {
                return NotFound();
            }
            return View(product);
        }

        public ActionResult Delete(int id)
        {
            var product = _productManager.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {
            bool isDeleted = _productManager.Delete(product);
            if(isDeleted)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}
