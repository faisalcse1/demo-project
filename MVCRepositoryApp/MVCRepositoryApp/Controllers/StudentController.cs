using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCRepositoryApp.Interfaces.Manager;
using MVCRepositoryApp.Manager;
using MVCRepositoryApp.Models;

namespace MVCRepositoryApp.Controllers
{
    public class StudentController : Controller
    {
        IStudentManager _studentManager=new StudentManager();
        // GET: Student
        public ActionResult Index()
        {
            var students = _studentManager.GetAll();
            return View(students);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if(ModelState.IsValid)
            {
                if(_studentManager.IsExistRegNo(student.RegNo))
                {
                    ViewBag.mgs = "Reg no already exist.";
                    return View(student);
                }
               bool isSaved= _studentManager.Add(student);
               if(isSaved)
               {
                   return RedirectToAction("Index");
               }
               else
               {
                   ViewBag.mgs = "Student save failed.";
               }
            }
            return View(student);
        }

        public ActionResult Edit(int id)
        {
            var student = _studentManager.GetById(id);
            if(student==null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if(ModelState.IsValid)
            {
                bool isUpdated = _studentManager.Update(student);
                if (isUpdated)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(student);
        }


        public ActionResult Details(int id)
        {
            var student = _studentManager.GetById(id);
            if(student==null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        public ActionResult Delete(int id)
        {
            var student = _studentManager.GetById(id);
            if(student==null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        [HttpPost]

        public ActionResult Delete(Student student)
        {
            bool isDeleted = _studentManager.Delete(student);
            if(isDeleted)
            {
                return RedirectToAction("Index");
            }
            return View(student);
        }
    }
}