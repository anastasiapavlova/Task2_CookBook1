using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    public interface IService<T>
    {
        List<T> GetList();
        void AddItem(T item);
        void AddItems(List<T> items);
        void DeleteItem(T item);
    }
}
