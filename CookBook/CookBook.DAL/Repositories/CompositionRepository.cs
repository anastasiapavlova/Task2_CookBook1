using CookBook.DAL.Interfaces;
using CookBook.Domain;
using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.DAL.Repositories
{
    public class CompositionRepository : ICompositionRepository
    {
        public void Add(Composition item)
        {
            var dataContext = new DataContext();
            dataContext.Add(item);
        }

        public void AddRange(List<Composition> items)
        {
            var dataContext = new DataContext();
            dataContext.AddRange(items);
        }

        public void Delete(Composition item)
        {
            var dataContext = new DataContext();
            dataContext.Delete(item);
        }

        public Composition Get(Composition item)
        {
            var dataContext = new DataContext();
            return dataContext.Get(item);
        }

        public List<Composition> GetList()
        {
            var dataContext = new DataContext();
            return dataContext.GetList<Composition>();
        }

        public void Update(Composition updateItem, Composition item)
        {
            var dataContext = new DataContext();
            dataContext.Update(updateItem, item);
        }
    }
}
