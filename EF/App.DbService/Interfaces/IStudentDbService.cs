using App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DbService
{
    public interface IStudentDbService: IRepository<Student,int>
    {
        IEnumerable<Student> Search(string quary);
    }
}
