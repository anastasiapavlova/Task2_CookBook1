using CookBook.DAL.Interfaces;
using CookBook.Domain;
using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.DAL.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        public void Add(Ingredient item)
        {
            var dataContext = new DataContext();
            dataContext.Add(item);
        }

        public void AddRange(List<Ingredient> items)
        {
            var dataContext = new DataContext();
            dataContext.AddRange(items);
        }

        public void Delete(Ingredient item)
        {
            var dataContext = new DataContext();
            dataContext.Delete(item);
        }

        public Ingredient Get(Ingredient item)
        {
            var dataContext = new DataContext();
            return dataContext.Get(item);
        }

        public List<Ingredient> GetList()
        {
            var dataContext = new DataContext();
            return dataContext.GetList<Ingredient>();
        }

        public void Update(Ingredient updateItem, Ingredient item)
        {
            var dataContext = new DataContext();
            dataContext.Update(updateItem, item);
        }
    }
}
