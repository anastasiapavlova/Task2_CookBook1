using CookBook.BLL.Interfaces;
using CookBook.DAL.Repositories;
using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.BLL.Services
{
    public class IngredientService : IIngredientService
    {
        private IngredientRepository repository;

        public IngredientService()
        {
            repository = new IngredientRepository();
        }

        public List<Ingredient> GetList()
        {
            return repository.GetList();
        }

        public void AddItem(Ingredient item)
        {
            repository.Add(item);
        }

        public void AddItems(List<Ingredient> items)
        {
            repository.AddRange(items);
        }

        public void DeleteItem(Ingredient item)
        {
            repository.Delete(item);
        }

        public void UpdateItem(Ingredient item)
        {
            repository.Update(item);
        }
    }
}
