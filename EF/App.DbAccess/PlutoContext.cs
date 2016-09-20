using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using App.Domain;

namespace App.DbAccess
{
    public class PlutoContext:DbContext
    {
        public PlutoContext():base("") {

        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentSubject> StudentSubjects { get; set; }
        public virtual DbSet<SubjectDiscription> SubjectDiscriptions { get; set; }
        public virtual DbSet<SubjectModule> SubjectModules { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
    }
}
