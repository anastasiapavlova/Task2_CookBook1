using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.DAL.Interfaces
{
    public interface ICompositionRepository
    {
        List<Composition> GetList();
        void AddRange(List<Composition> items);
        void Update(Composition updateItem, Composition item);
        void Delete(Composition item);
        void Add(Composition item);
    }
}
