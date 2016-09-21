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
    public class SubjectDbService : PlutoContext, ISubjectDbService, ISubjectDiscriptionDbService, ISubjectModuleDbService
    {
        SubjectDiscription IRepository<SubjectDiscription, int>.Create(SubjectDiscription item)
        {
            throw new NotImplementedException();
        }

        SubjectModule IRepository<SubjectModule, int>.Create(SubjectModule item)
        {
            throw new NotImplementedException();
        }

        Subject IRepository<Subject, int>.Create(Subject item)
        {
            throw new NotImplementedException();
        }

        void IRepository<SubjectModule, int>.Delete(int Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<SubjectDiscription, int>.Delete(int Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Subject, int>.Delete(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<SubjectModule> IRepository<SubjectModule, int>.Read()
        {
            throw new NotImplementedException();
        }

        IEnumerable<SubjectDiscription> IRepository<SubjectDiscription, int>.Read()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Subject> IRepository<Subject, int>.Read()
        {
            throw new NotImplementedException();
        }

        SubjectDiscription IRepository<SubjectDiscription, int>.Read(int Id)
        {
            throw new NotImplementedException();
        }

        SubjectModule IRepository<SubjectModule, int>.Read(int Id)
        {
            throw new NotImplementedException();
        }

        Subject IRepository<Subject, int>.Read(int Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<SubjectModule, int>.Update(SubjectModule item)
        {
            throw new NotImplementedException();
        }

        void IRepository<SubjectDiscription, int>.Update(SubjectDiscription item)
        {
            throw new NotImplementedException();
        }

        void IRepository<Subject, int>.Update(Subject item)
        {
            throw new NotImplementedException();
        }
    }
}
