using CookBook.DAL.Interfaces;
using CookBook.Domain.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CookBook.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void Add(User item)
        {
            using (var context = new CookBookContext())
            {
                context.Users.Add(item);
                context.SaveChanges();
            }
        }

        public void AddRange(List<User> items)
        {
            using (var context = new CookBookContext())
            {
                context.Users.AddRange(items);
                context.SaveChanges();
            }
        }

        public void Delete(User item)
        {
            using (var context = new CookBookContext())
            {
                if (item != null)
                {
                    context.Users.Attach(item);
                    context.Users.Remove(item);
                    context.SaveChanges();
                }
            }
        }

        public List<User> GetList()
        {
            using (var context = new CookBookContext())
            {
                return context.Users.ToList();
            }
        }

        public void Update(User item)
        {
            using (var context = new CookBookContext())
            {
                if(item != null)
                {
                    context.Entry(item).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }
    }
}
