using System.Collections.Generic;

namespace DataAccess.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetList();
        void AddList(List<T> items);
        T Get(T item);
        void Update(T item);
        void Delete(T item);
        void Add(T item);
    }
}
