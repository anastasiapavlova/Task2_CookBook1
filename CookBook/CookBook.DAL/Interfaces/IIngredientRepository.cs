using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.DAL.Interfaces
{
    public interface IIngredientRepository
    {
        List<Ingredient> GetList();
        void AddRange(List<Ingredient> items);
        Ingredient Get(Ingredient item);
        void Update(Ingredient updateItem, Ingredient item);
        void Delete(Ingredient item);
        void Add(Ingredient item);
    }
}
