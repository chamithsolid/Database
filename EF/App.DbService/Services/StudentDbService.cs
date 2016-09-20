using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain;
using App.DbAccess;
using App.Utility;
using App.Utility.CustomException;

namespace App.DbService
{
    public class StudentDbService : PlutoContext, IStudentDbService
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
                    throw new ObjectNotFoundException();
                }
                dba.Students.Remove(obj);
                dba.SaveChanges();
            }
            catch 
            {
                throw;
            }
        }

        public IEnumerable<Student> Read()
        {
            try
            {
                return dba.Students.ToList();
            }
            catch  
            {
                throw;
            }
        }

        public Student Read(int Id)
        {
            try
            {
                var obj =  dba.Students.Where(p=>p.Id==Id).FirstOrDefault();
                if (obj == null)
                {
                    throw new ObjectNotFoundException();
                }
                return obj;
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Student> Search(string quary)
        {
            try
            {
               return dba.Students.Where(p => p.StudentName.ToLower().StartsWith(quary.ToLower().Trim())).ToList();
            }
            catch
            {
                throw;
            }
        }

        public void Update(Student item)
        {
            try
            {
                var obj = dba.Students.Where(p => p.Id == item.Id).FirstOrDefault();
                if (obj == null)
                {
                    throw new ObjectNotFoundException();
                }
                obj.Email = item.Email;
                obj.Phone = item.Phone;
                obj.StudentName = item.StudentName;
                dba.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
