using System.Collections.Generic;
using CookBook.BLL.Interfaces;
using CookBook.DAL.Repositories;

namespace CookBook.BLL.Services
{
    public class MainService<T> : IService<T>
        where T : class
    {
        private BaseRepository<T> repository;

        public MainService()
        {
            repository = new BaseRepository<T>();
        }

        public List<T> GetList()
        {
            return repository.GetList();
        }

        public void AddItem(T item)
        {
            repository.Add(item);
        }

        public void AddItems(List<T> items)
        {
            repository.AddRange(items);
        }

        public void DeleteItem(T item)
        {
            repository.Delete(item);
        }

        public void UpdateItem(T updateItem, T item)
        {
            repository.Update(updateItem, item);
        }
    }
}
