using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EF.Repository.Repository;
using MVCRepositoryApp.Data;
using MVCRepositoryApp.Interfaces.Repository;
using MVCRepositoryApp.Models;

namespace MVCRepositoryApp.Repository
{
    public class StudentRepository:CommonRepository<Student>,IStudentRepository
    {
        public StudentRepository():base(new ApplicationDbContext())
        {
            
        }
    }
}