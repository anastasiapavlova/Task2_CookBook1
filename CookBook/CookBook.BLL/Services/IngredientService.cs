using System;
using System.Linq;
using CookBook.BLL.Models;
using CookBook.Domain.Models;
using CookBook.BLL.Interfaces;
using CookBook.DAL.Interfaces;
using System.Collections.Generic;


namespace CookBook.BLL.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _ingredientRepository;

        public IngredientService(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        public List<IngredientModel> GetList()
        {
            var resultList = _ingredientRepository.GetList();

            return resultList.Select(x => new IngredientModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }

        public Guid AddItem(IngredientModel item)
        {
            return _ingredientRepository.Add(new Ingredient { Name = item.Name});
        }

        public void AddItems(List<Ingredient> items)
        {
            _ingredientRepository.AddRange(items);
        }

        public void DeleteItem(Guid id)
        {
            _ingredientRepository.Delete(id);
        }

        public void UpdateItem(Ingredient item)
        {
            _ingredientRepository.Update(item);
        }
    }
}
