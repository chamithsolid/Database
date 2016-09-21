using App.DbAccess;
using App.DbService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain;

namespace App.DbService.Services
{
    public class StudentSubjectDbService : PlutoContext, IStudentSubjectDbService
    {
        public StudentSubject Create(StudentSubject item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StudentSubject> Read()
        {
            throw new NotImplementedException();
        }

        public StudentSubject Read(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(StudentSubject item)
        {
            throw new NotImplementedException();
        }
    }
}
