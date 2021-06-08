using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Repository.Interface.Repository;
using MVCRepositoryApp.Models;

namespace MVCRepositoryApp.Interfaces.Repository
{
    interface IStudentRepository:ICommonRepository<Student>
    {
    }
}
