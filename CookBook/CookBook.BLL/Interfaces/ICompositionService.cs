using System;
using CookBook.BLL.Models;
using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.BLL.Interfaces
{
    public interface ICompositionService
    {
        List<CompositionModel> GetList();
        void AddItem(CompositionModel item);
        void AddItems(List<Composition> items);
        void DeleteItem(Guid id);
        void UpdateItem(Composition item);
    }
}
