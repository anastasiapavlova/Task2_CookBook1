using CookBook.DAL.Interfaces;
using CookBook.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CookBook.DAL.Repositories
{
    public class CompositionRepository : ICompositionRepository
    {
        public void Add(Composition item)
        {
            using (var context = new CookBookContext())
            {
                context.Compositions.Add(item);
                context.SaveChanges();
            }
        }

        public void AddRange(List<Composition> items)
        {
            using (var context = new CookBookContext())
            {
                context.Compositions.AddRange(items);
                context.SaveChanges();
            }
        }
        
        public void Delete(Guid id)
        {
            using (var context = new CookBookContext())
            {
                if (id != null)
                {
                    context.Compositions.Remove(context.Compositions.FirstOrDefault(x => x.Id == id));
                    context.SaveChanges();
                }
            }
        }

        public List<Composition> GetList()
        {
            using (var context = new CookBookContext())
            {
                return context.Compositions.ToList();
            }
        }

        public void Update(Composition item)
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
