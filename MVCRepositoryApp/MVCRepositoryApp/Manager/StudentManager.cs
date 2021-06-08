using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EF.Repository.Manager;
using MVCRepositoryApp.Interfaces.Manager;
using MVCRepositoryApp.Models;
using MVCRepositoryApp.Repository;

namespace MVCRepositoryApp.Manager
{
    public class StudentManager:CommonManager<Student>,IStudentManager
    {
        public StudentManager():base(new StudentRepository())
        {
            
        }

        public Student GetById(int id)
        {
            return GetFirstOrDefault(c => c.Id == id);
        }

        public bool IsExistRegNo(string regNo)
        {
            var student = GetFirstOrDefault(c => c.RegNo.ToLower() == regNo.ToLower());
            if(student!=null)
            {
                return true;
            }

            return false;
        }
    }
}