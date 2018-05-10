using System;
using CookBook.BLL.Models;
using System.Collections.Generic;

namespace CookBook.BLL.Interfaces
{
    public interface IRecipeService
    {
        List<RecipeModel> GetList();
        RecipeModel GetItem(Guid id);
        void AddItem(RecipeModel item);
        void AddItems(List<RecipeModel> items);
        void DeleteItem(Guid id);
        void UpdateItem(RecipeModel item);
    }
}
