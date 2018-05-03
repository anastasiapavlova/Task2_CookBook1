using CookBook.DAL.Interfaces;
using CookBook.Domain;
using CookBook.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace CookBook.DAL.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        public void Add(Review item)
        {
            using (var context = new CookBookContext())
            {
                context.Reviews.Add(item);
                context.SaveChanges();
            }
        }

        public void AddRange(List<Review> items)
        {
            using (var context = new CookBookContext())
            {
                context.Reviews.AddRange(items);
                context.SaveChanges();
            }
        }

        public void Delete(Review item)
        {
            using (var context = new CookBookContext())
            {
                if (item != null)
                {
                    context.Reviews.Attach(item);
                    context.Reviews.Remove(item);
                    context.SaveChanges();
                }
            }
        }

        public List<Review> GetList()
        {
            using (var context = new CookBookContext())
            {
                return context.Reviews.ToList();
            }
        }

        public void Update(Review updateItem, Review item)
        {
            using (var context = new CookBookContext())
            {
                if (updateItem != null && item != null)
                {
                    context.Reviews.Attach(updateItem);
                    updateItem = item;
                    context.SaveChanges();
                }
            }
        }
    }
}
