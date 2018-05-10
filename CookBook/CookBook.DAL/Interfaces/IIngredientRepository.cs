using System;
using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.DAL.Interfaces
{
    public interface IIngredientRepository
    {
        List<Ingredient> GetList();
        void AddRange(List<Ingredient> items);
        void Update(Ingredient item);
        void Delete(Guid id);
        Guid Add(Ingredient item);
    }
}
