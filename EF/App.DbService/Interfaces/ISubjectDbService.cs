using App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DbService.Interfaces
{
    public interface ISubjectDbService: IRepository<Subject, int>
    {
    }
}
