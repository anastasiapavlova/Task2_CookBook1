using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CookBook.DAL.Interfaces;

namespace CookBook.DAL.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        public void Add(T item)
        {
            using (var context = new CookBookContext())
            {
                if (item != null)
                {
                    var dbSet = context.Set<T>();
                    dbSet.Add(item);
                    context.SaveChanges();
                }
            }
        }

        public void Delete(T item)
        {
            using (var context = new CookBookContext())
            {
                if (item != null)
                {
                    var dbSet = context.Set<T>();
                    dbSet.Remove(item);
                    context.SaveChanges();
                }
            }
        }

        public List<T> GetList()
        {
            using (var context = new CookBookContext())
            {
                var dbSet = context.Set<T>();
                return dbSet.AsNoTracking().ToList();
            }
        }

        public void AddRange(List<T> items)
        {
            using (var context = new CookBookContext())
            {
                if (items != null)
                {
                    var dbSet = context.Set<T>();
                    dbSet.AddRange(items);
                    context.SaveChanges();
                }
            }
        }

        public void Update(T item)
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
