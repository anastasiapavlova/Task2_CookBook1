using CookBook.DAL.Interfaces;
using CookBook.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void Delete(Guid id)
        {
            using (var context = new CookBookContext())
            {
                if (id != null)
                {
                    context.Reviews.Remove(context.Reviews.FirstOrDefault(x => x.Id == id));
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

        public void Update(Review item)
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
