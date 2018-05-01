using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.DAL.Interfaces
{
    public interface IRecipeRepository
    {
        List<Recipe> GetList();
        void AddRange(List<Recipe> items);
        Recipe Get(Recipe item);
        void Update(Recipe updateItem, Recipe item);
        void Delete(Recipe item);
        void Add(Recipe item);
    }
}
