using Microsoft.AspNetCore.Mvc;
using MongoWithCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MongoWithCoreApp.Controllers
{
    public class StudentController : Controller
    {
        private MongoClient client = new MongoClient("mongodb://127.0.0.1:27017/");

        public IActionResult Index()
        {
            var database = client.GetDatabase("universityDatabase");
            var table = database.GetCollection<Student>("students");
            var students = table.Find(FilterDefinition<Student>.Empty).ToList();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            var database = client.GetDatabase("universityDatabase");
            var table = database.GetCollection<Student>("students");
            student.Id = Guid.NewGuid().ToString();
            table.InsertOne(student);
            //ViewBag.Mgs = "Student has been saved.";
            return RedirectToAction("Index");
        }

        public ActionResult Edit(string id)
        {
            var database = client.GetDatabase("universityDatabase");
            var table = database.GetCollection<Student>("students");
            var student = table.Find(c => c.Id == id).FirstOrDefault();
            if(student==null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if(string.IsNullOrEmpty(student.Id))
            {
                ViewBag.Mgs = "Please provide id";
                return View(student);
            }
            var database = client.GetDatabase("universityDatabase");
            var table = database.GetCollection<Student>("students");
            table.ReplaceOne(c => c.Id == student.Id, student);
            return RedirectToAction("Index");
        }

        public ActionResult Details(string id)
        {
            var database = client.GetDatabase("universityDatabase");
            var table = database.GetCollection<Student>("students");
            var student = table.Find(c => c.Id == id).FirstOrDefault();
            if(student==null)
            {
                return NotFound();
            }
            return View(student);
        }

        public ActionResult Delete(string id)
        {
            var database = client.GetDatabase("universityDatabase");
            var table = database.GetCollection<Student>("students");
            var student = table.Find(c => c.Id == id).FirstOrDefault();
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public ActionResult Delete(Student student)
        {
            var database = client.GetDatabase("universityDatabase");
            var table = database.GetCollection<Student>("students");
            table.DeleteOne(c => c.Id == student.Id);
            return RedirectToAction("Index");
        }

    }
}
