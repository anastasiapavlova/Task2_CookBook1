using CookBook.BLL.Interfaces;
using CookBook.DAL.Repositories;
using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.BLL.Services
{
    public class ReviewService : IReviewService
    {
        private ReviewRepository repository;

        public ReviewService()
        {
            repository = new ReviewRepository();
        }

        public List<Review> GetList()
        {
            return repository.GetList();
        }

        public void AddItem(Review item)
        {
            repository.Add(item);
        }

        public void AddItems(List<Review> items)
        {
            repository.AddRange(items);
        }

        public void DeleteItem(Review item)
        {
            repository.Delete(item);
        }

        public void UpdateItem(Review updateItem, Review item)
        {
            repository.Update(updateItem, item);
        }
    }
}
