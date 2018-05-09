using CookBook.Domain.Models;
using System;
using System.Collections.Generic;

namespace CookBook.DAL.Interfaces
{
    public interface IReviewRepository
    {
        List<Review> GetList();
        void AddRange(List<Review> items);
        void Update(Review item);
        void Delete(Guid id);
        void Add(Review item);
    }
}
