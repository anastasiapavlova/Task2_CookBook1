using System;
using CookBook.BLL.Models;
using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.BLL.Interfaces
{
    public interface IReviewService
    {
        List<ReviewModel> GetList();
        void AddItem(Review item);
        void AddItems(List<Review> items);
        void DeleteItem(Guid id);
        void UpdateItem(Review item);
    }
}
