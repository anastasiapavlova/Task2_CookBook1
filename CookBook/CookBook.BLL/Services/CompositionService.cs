using CookBook.BLL.Interfaces;
using CookBook.DAL.Repositories;
using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.BLL.Services
{
    public class CompositionService : ICompositionService
    {
        private CompositionRepository repository;
        public CompositionService()
        {
            repository = new CompositionRepository();
        }

        public List<Composition> GetList()
        {
            return repository.GetList();
        }

        public void AddItem(Composition item)
        {
            repository.Add(item);
        }

        public void AddItems(List<Composition> items)
        {
            repository.AddRange(items);
        }

        public void DeleteItem(Composition item)
        {
            repository.Delete(item);
        }

        public void UpdateItem(Composition item)
        {
            repository.Update(item);
        }
    }
}
