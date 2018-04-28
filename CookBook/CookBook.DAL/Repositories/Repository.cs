using System.Collections.Generic;
using CookBook.DAL.Interfaces;
using CookBook.Domain;

namespace CookBook.DAL.Repositories
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        public void Add(T item)
        {
            var dataContext = new DataContext();
            dataContext.Add<T>(item);
        }

        public void Delete(T item)
        {
            var dataContext = new DataContext();
            dataContext.Delete<T>(item);
        }

        public List<T> GetList()
        {
            var dataContext = new DataContext();
            return dataContext.GetList<T>();
        }

        public void AddRange(List<T> items)
        {
            var dataContext = new DataContext();
            dataContext.AddRange(items);
        }

        public T Get(T item)
        {
            var dataContext = new DataContext();
            return dataContext.Get(item);
        }

        public void Update(T updateItem, T item)
        {
            var dataContext = new DataContext();
            dataContext.Update(updateItem, item);
        }
    }
}
