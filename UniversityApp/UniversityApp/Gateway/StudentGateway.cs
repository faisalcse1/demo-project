using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using UniversityApp.Models;

namespace UniversityApp.Gateway
{
    public class StudentGateway
    {
        public List<Student> GetStudents()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T83H3EE;Initial Catalog=PBL2;Integrated Security = SSPI;");
            string query = "SELECT * FROM vStudentInfo";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> students = new List<Student>();
            while(reader.Read())
            {
                Student student = new Student();
                student.StudentName = reader["StudentName"].ToString();
                student.RegNo = reader["RegNo"].ToString();
                student.Email = reader["Email"].ToString();
                student.Address = reader["Address"].ToString();
                student.DepartmentName = reader["DepartmentName"].ToString();
                students.Add(student);
            }
            con.Close();
            return students;
        }

        public List<Department>GetDepartments()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T83H3EE;Initial Catalog=PBL2;Integrated Security = SSPI;");
            string query = "SELECT * FROM Department_tb";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Department> departments = new List<Department>();
            while(reader.Read())
            {
                Department department = new Department();
                department.Id = (int)reader["Id"];
                department.ShortName = reader["ShortName"].ToString();
                departments.Add(department);
            }
            con.Close();
            return departments;
        }
    }
}
