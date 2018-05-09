using CookBook.Domain.Models;
using System;
using System.Collections.Generic;

namespace CookBook.DAL.Interfaces
{
    public interface IRecipeRepository
    {
        List<Recipe> GetList();
        void AddRange(List<Recipe> items);
        void Update(Recipe item);
        void Delete(Guid id);
        void Add(Recipe item);
        Recipe GetItem(Guid id);
    }
}
