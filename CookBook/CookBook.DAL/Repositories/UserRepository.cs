using System;
using System.Linq;
using System.Data.Entity;
using CookBook.Domain.Models;
using CookBook.DAL.Interfaces;
using System.Collections.Generic;

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

        public void Delete(Guid id)
        {
            using (var context = new CookBookContext())
            {
                if (id != null)
                {
                    context.Users.Remove(context.Users.FirstOrDefault(x => x.Id == id));
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
