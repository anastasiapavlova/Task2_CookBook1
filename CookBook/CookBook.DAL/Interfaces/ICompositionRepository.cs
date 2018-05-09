using CookBook.Domain.Models;
using System;
using System.Collections.Generic;

namespace CookBook.DAL.Interfaces
{
    public interface ICompositionRepository
    {
        List<Composition> GetList();
        void AddRange(List<Composition> items);
        void Update(Composition item);
        void Delete(Guid id);
        void Add(Composition item);
    }
}
