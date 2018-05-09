using CookBook.BLL.Models;
using CookBook.Domain.Models;
using System;
using System.Collections.Generic;

namespace CookBook.BLL.Interfaces
{
    public interface IIngredientService
    {
        List<IngredientModel> GetList();
        Guid AddItem(IngredientModel item);
        void AddItems(List<Ingredient> items);
        void DeleteItem(Guid id);
        void UpdateItem(Ingredient item);
    }
}
