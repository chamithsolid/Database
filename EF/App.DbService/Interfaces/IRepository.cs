using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DbService
{
    public interface IRepository<T,in TKey>   where T :class
    {
        T Create(T item);
        void Delete(TKey Id);
        void Update(T item);
        IEnumerable<T> Read();
        T Read(int Id);
    }
}
