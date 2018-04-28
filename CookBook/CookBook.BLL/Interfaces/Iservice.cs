using System.Collections.Generic;

namespace CookBook.BLL.Interfaces
{
    public interface IService<T>
    {
        List<T> GetList();
        void AddItem(T item);
        void AddItems(List<T> items);
        void DeleteItem(T item);
        void UpdateItem(T updateItem, T item);
    }
}
