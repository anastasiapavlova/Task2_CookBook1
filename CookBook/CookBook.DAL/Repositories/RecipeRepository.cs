using CookBook.DAL.Interfaces;
using CookBook.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void Delete(Guid id)
        {
            using (var context = new CookBookContext())
            {
                if (id!=null)
                {
                    context.Recipes.Remove(context.Recipes.FirstOrDefault(x=>x.Id == id));
                    context.SaveChanges();
                }
            }
        }

        public Recipe GetItem(Guid id)
        {
            using (var context = new CookBookContext())
            {
                return context.Recipes.FirstOrDefault(x=>x.Id == id);
            }
        }

        public List<Recipe> GetList()
        {
            using (var context = new CookBookContext())
            {
                return context.Recipes.ToList();
            }
        }

        public void Update(Recipe item)
        {
            using (var context = new CookBookContext())
            {
                if (item != null)
                {
                    context.Entry(item).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }
    }
}
