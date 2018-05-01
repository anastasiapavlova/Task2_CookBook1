using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.DAL.Interfaces
{
    public interface IReviewRepository
    {
        List<Review> GetList();
        void AddRange(List<Review> items);
        Review Get(Review item);
        void Update(Review updateItem, Review item);
        void Delete(Review item);
        void Add(Review item);
    }
}
