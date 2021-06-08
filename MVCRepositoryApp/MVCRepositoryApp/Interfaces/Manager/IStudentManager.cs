using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Repository.Interface.Manager;
using MVCRepositoryApp.Models;

namespace MVCRepositoryApp.Interfaces.Manager
{
    interface IStudentManager:ICommonManager<Student>
    {
        bool IsExistRegNo(string regNo);
        Student GetById(int id);
    }
}
