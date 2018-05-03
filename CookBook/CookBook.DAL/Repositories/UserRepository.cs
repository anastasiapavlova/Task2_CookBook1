using CookBook.DAL.Interfaces;
using CookBook.Domain;
using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void Add(User item)
        {
            //var dataContext = new DataContext();
            //dataContext.Add(item);

            CookBookContext context = new CookBookContext();
            context.Users.Add(item);
            context.SaveChanges();
        }

        public void AddRange(List<User> items)
        {
            var dataContext = new DataContext();
            dataContext.AddRange(items);
        }

        public void Delete(User item)
        {
            var dataContext = new DataContext();
            dataContext.Delete(item);
        }

        public User Get(User item)
        {
            var dataContext = new DataContext();
            return dataContext.Get(item);
        }

        public List<User> GetList()
        {
            var dataContext = new DataContext();
            return dataContext.GetList<User>();
        }

        public void Update(User updateItem, User item)
        {
            var dataContext = new DataContext();
            dataContext.Update(updateItem, item);
        }
    }
}
