using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityApp.Gateway;
using UniversityApp.Models;

namespace UniversityApp.Manager
{
    public class StudentManager
    {
        StudentGateway studentGateway = new StudentGateway();

        public List<Student>GetStudents()
        {
            return studentGateway.GetStudents();
        }

        public List<Department> GetDepartments()
        {
            return studentGateway.GetDepartments();
        }
    }
}
