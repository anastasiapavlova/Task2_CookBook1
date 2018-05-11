using System;
using Ninject;
using System.Linq;
using CookBook.BLL.Models;
using CookBook.BLL.Mappers;
using CookBook.Domain.Models;
using CookBook.BLL.Interfaces;
using CookBook.DAL.Interfaces;
using System.Collections.Generic;

namespace CookBook.BLL.Services
{
    public class IngredientService : IIngredientService
    {
        [Inject]
        public IIngredientRepository IngredientRepository { get; set; }
        
        public List<IngredientModel> GetList()
        {
            var resultList = IngredientRepository.GetList();

            return resultList.Select(IngredientMapper.ConvertIngredientToIngredientModel).ToList();
        }

        public Guid AddItem(IngredientModel item)
        {
            return IngredientRepository.Add(new Ingredient { Name = item.Name});
        }

        public void AddItems(List<Ingredient> items)
        {
            IngredientRepository.AddRange(items);
        }

        public void DeleteItem(Guid id)
        {
            IngredientRepository.Delete(id);
        }

        public void UpdateItem(Ingredient item)
        {
            IngredientRepository.Update(item);
        }
    }
}
