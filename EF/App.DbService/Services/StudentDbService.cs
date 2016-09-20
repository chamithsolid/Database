using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain;
using App.DbAccess;

namespace App.DbService
{
    public class StudentDbService : PlutoContext, IStudent
    {
        PlutoContext dba = null;
        public StudentDbService() { dba = new PlutoContext(); }

        public Student Create(Student item)
        {
            try
            {
                dba.Students.Add(item);
                dba.SaveChanges();
                return item;
            }
            catch 
            {
                throw;
            }
        }

        public void Delete(int Id)
        {
            try
            {
                var obj = dba.Students.Where(p => p.Id == Id).FirstOrDefault();
                if (obj == null)
                {
                    throw new Exception("");
                }
            }
            catch 
            {

                throw;
            }
        }

        public IEnumerable<Student> Read()
        {
            throw new NotImplementedException();
        }

        public Student Read(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> Search(string quary)
        {
            throw new NotImplementedException();
        }

        public void Update(Student item)
        {
            throw new NotImplementedException();
        }
    }
}
