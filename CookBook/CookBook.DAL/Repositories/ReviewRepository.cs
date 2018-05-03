using CookBook.DAL.Interfaces;
using CookBook.Domain;
using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.DAL.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        public void Add(Review item)
        {
            //var dataContext = new DataContext();
            //dataContext.Add(item);

            CookBookContext context = new CookBookContext();
            context.Reviews.Add(item);
            context.SaveChanges();
        }

        public void AddRange(List<Review> items)
        {
            var dataContext = new DataContext();
            dataContext.AddRange(items);
        }

        public void Delete(Review item)
        {
            var dataContext = new DataContext();
            dataContext.Delete(item);
        }

        public Review Get(Review item)
        {
            var dataContext = new DataContext();
            return dataContext.Get(item);
        }

        public List<Review> GetList()
        {
            var dataContext = new DataContext();
            return dataContext.GetList<Review>();
        }

        public void Update(Review updateItem, Review item)
        {
            var dataContext = new DataContext();
            dataContext.Update(updateItem, item);
        }
    }
}
