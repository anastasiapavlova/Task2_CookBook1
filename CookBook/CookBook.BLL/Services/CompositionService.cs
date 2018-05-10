using System;
using System.Linq;
using CookBook.BLL.Models;
using CookBook.BLL.Mappers;
using CookBook.Domain.Models;
using CookBook.BLL.Interfaces;
using CookBook.DAL.Interfaces;
using System.Collections.Generic;


namespace CookBook.BLL.Services
{
    public class CompositionService : ICompositionService
    {
        private readonly ICompositionRepository _compositionRepository;

        public CompositionService(ICompositionRepository compositionRepository)
        {
            _compositionRepository = compositionRepository;
        }

        public List<CompositionModel> GetList()
        {
            var resultList = _compositionRepository.GetList();

            return resultList.Select(x => new CompositionModel
            {
                Id = x.Id,
                RecipeId = x.RecipeId,
                IngredientId = x.Id,
                Quantity = x.Quantity
            }).ToList();
        }

        public void AddItem(CompositionModel item)
        {
            _compositionRepository.Add(CompositionMapper.ConvertCompositonModelToComposition(item));
        }

        public void AddItems(List<Composition> items)
        {
            _compositionRepository.AddRange(items);
        }

        public void DeleteItem(Guid id)
        {
            _compositionRepository.Delete(id);
        }

        public void UpdateItem(Composition item)
        {
            _compositionRepository.Update(item);
        }
    }
}
