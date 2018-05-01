using CookBook.DAL.Interfaces;
using CookBook.Domain;
using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.DAL.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        public void Add(Recipe item)
        {
            var dataContext = new DataContext();
            dataContext.Add(item);
        }

        public void AddRange(List<Recipe> items)
        {
            var dataContext = new DataContext();
            dataContext.AddRange(items);
        }

        public void Delete(Recipe item)
        {
            var dataContext = new DataContext();
            dataContext.Delete(item);
        }

        public Recipe Get(Recipe item)
        {
            var dataContext = new DataContext();
            return dataContext.Get(item);
        }

        public List<Recipe> GetList()
        {
            var dataContext = new DataContext();
            return dataContext.GetList<Recipe>();
        }

        public void Update(Recipe updateItem, Recipe item)
        {
            var dataContext = new DataContext();
            dataContext.Update(updateItem, item);
        }
    }
}
