using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UniversityApp.Manager;
using UniversityApp.Models;

namespace UniversityApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult SaveStudent()
        {
            StudentManager studentManager = new StudentManager();
            ViewBag.Department = studentManager.GetDepartments();
            ViewBag.Students =studentManager.GetStudents();
            return View();

        }

       [HttpPost]
        public ActionResult SaveStudent(Student student)
        {
            string mgs = "";
            StudentManager studentManager = new StudentManager();
            if(ModelState.IsValid)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T83H3EE;Initial Catalog=PBL2;Integrated Security = SSPI;");
                string query = "INSERT INTO Student_tb(StudentName,RegNo,Email,Address,DepartmentId)Values('" + student.StudentName + "','" + student.RegNo + "','" + student.Email + "','" + student.Address + "','" + student.DepartmentName + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    mgs = "Save data successfully";
                }
                else
                {
                    mgs = "Saved failed";
                }
            }
            

            ViewBag.Department = studentManager.GetDepartments();
            ViewBag.Students = studentManager.GetStudents();
            ViewBag.Message = mgs;
            return View();
        }

            
        public ActionResult GetAll()
        {
            //ViewBag.Students = Students();
            return View(Students());
        }

       
        public List<string>GetDepartments()
        {
            return new List<string>(){ "CSE","EEE","ENG"};
        }

        public List<Student>Students()
        {
            return new List<Student>
            {
                new Student{StudentName="Ali Reja",RegNo="2017",Email="alireja@gmail.com",Address="Dhaka",DepartmentName="CSE"},
                new Student{StudentName="Ismail",RegNo="2018",Email="ismail@gmail.com",Address="Dhaka",DepartmentName="CSE"}
            };
        }
             
    }
}