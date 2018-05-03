using CookBook.DAL.Interfaces;
using CookBook.Domain;
using CookBook.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace CookBook.DAL.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        public void Add(Recipe item)
        {
            using (var context = new CookBookContext())
            {
                context.Recipes.Add(item);
                context.SaveChanges();
            }
        }

        public void AddRange(List<Recipe> items)
        {
            using (var context = new CookBookContext())
            {
                context.Recipes.AddRange(items);
                context.SaveChanges();
            }
        }

        public void Delete(Recipe item)
        {
            using (var context = new CookBookContext())
            {
                if (item != null)
                {
                    context.Recipes.Attach(item);
                    context.Recipes.Remove(item);
                    context.SaveChanges();
                }
            }
        }

        public List<Recipe> GetList()
        {
            using (var context = new CookBookContext())
            {
                return context.Recipes.ToList();
            }
        }

        public void Update(Recipe updateItem, Recipe item)
        {
            using (var context = new CookBookContext())
            {
                if (updateItem != null && item != null)
                {
                    context.Recipes.Attach(updateItem);
                    updateItem = item;
                    context.SaveChanges();
                }
            }
        }
    }
}
