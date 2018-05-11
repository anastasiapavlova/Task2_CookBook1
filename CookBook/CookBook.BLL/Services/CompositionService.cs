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
    public class CompositionService : ICompositionService
    {
        [Inject]
        public ICompositionRepository CompositionRepository { get; set; }

        public List<CompositionModel> GetList()
        {
            var resultList = CompositionRepository.GetList();

            return resultList.Select(CompositionMapper.ConvertCompositonToCompositionModel).ToList();
        }

        public void AddItem(CompositionModel item)
        {
            CompositionRepository.Add(CompositionMapper.ConvertCompositonModelToComposition(item));
        }

        public void AddItems(List<Composition> items)
        {
            CompositionRepository.AddRange(items);
        }

        public void DeleteItem(Guid id)
        {
            CompositionRepository.Delete(id);
        }

        public void UpdateItem(Composition item)
        {
            CompositionRepository.Update(item);
        }
    }
}
