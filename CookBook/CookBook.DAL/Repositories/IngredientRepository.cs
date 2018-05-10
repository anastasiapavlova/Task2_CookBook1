using System;
using System.Linq;
using System.Data.Entity;
using CookBook.Domain.Models;
using CookBook.DAL.Interfaces;
using System.Collections.Generic;

namespace CookBook.DAL.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        public Guid Add(Ingredient item)
        {
            using (var context = new CookBookContext())
            {
                context.Ingredients.Add(item);
                context.SaveChanges();
                return item.Id;
            }
        }

        public void AddRange(List<Ingredient> items)
        {
            using (var context = new CookBookContext())
            {
                context.Ingredients.AddRange(items);
                context.SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            using (var context = new CookBookContext())
            {
                if (id != null)
                {
                    context.Ingredients.Remove(context.Ingredients.FirstOrDefault(x => x.Id == id));
                    context.SaveChanges();
                }
            }
        }

        public List<Ingredient> GetList()
        {
            using (var context = new CookBookContext())
            {
                return context.Ingredients.ToList();
            }
        }

        public void Update(Ingredient item)
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
