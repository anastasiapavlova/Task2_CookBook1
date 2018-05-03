using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.BLL.Interfaces
{
    public interface ICompositionService
    {
        List<Composition> GetList();
        void AddItem(Composition item);
        void AddItems(List<Composition> items);
        void DeleteItem(Composition item);
        void UpdateItem(Composition item);
    }
}
