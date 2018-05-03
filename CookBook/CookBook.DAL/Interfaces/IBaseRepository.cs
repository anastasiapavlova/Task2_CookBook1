using System.Collections.Generic;

namespace CookBook.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        List<T> GetList();
        void AddRange(List<T> items);
        void Update(T item);
        void Delete(T item);
        void Add(T item);
    }
}
