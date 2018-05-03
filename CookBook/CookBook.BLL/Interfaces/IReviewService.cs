using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.BLL.Interfaces
{
    public interface IReviewService
    {
        List<Review> GetList();
        void AddItem(Review item);
        void AddItems(List<Review> items);
        void DeleteItem(Review item);
        void UpdateItem(Review item);
    }
}
