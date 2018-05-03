﻿using CookBook.DAL.Interfaces;
using CookBook.Domain;
using CookBook.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace CookBook.DAL.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        public void Add(Ingredient item)
        {
            using (var context = new CookBookContext())
            {
                context.Ingredients.Add(item);
                context.SaveChanges();
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

        public void Delete(Ingredient item)
        {
            using (var context = new CookBookContext())
            {
                if (item != null)
                {
                    context.Ingredients.Attach(item);
                    context.Ingredients.Remove(item);
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

        public void Update(Ingredient updateItem, Ingredient item)
        {
            using (var context = new CookBookContext())
            {
                if (updateItem != null && item != null)
                {
                    context.Ingredients.Attach(updateItem);
                    updateItem = item;
                    context.SaveChanges();
                }
            }
        }
    }
}
