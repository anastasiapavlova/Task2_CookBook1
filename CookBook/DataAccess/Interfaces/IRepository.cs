using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetList();
        T List();
        void Update(T item);
        void Delete(T item);
        void Add(T item);
    }
}
