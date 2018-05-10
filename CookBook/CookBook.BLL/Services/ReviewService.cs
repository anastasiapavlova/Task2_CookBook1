using System;
using System.Linq;
using CookBook.BLL.Models;
using CookBook.Domain.Models;
using CookBook.BLL.Interfaces;
using CookBook.DAL.Interfaces;
using System.Collections.Generic;

namespace CookBook.BLL.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public List<ReviewModel> GetList()
        {
            var resultList = _reviewRepository.GetList();

            return resultList.Select(x => new ReviewModel
            {
                Id = x.Id,
                UserId = x.UserId,
                RecipeId = x.RecipeId,
                Description = x.Description,
                CreationDate = x.CreationDate
            }).ToList();
        }

        public void AddItem(Review item)
        {
            _reviewRepository.Add(item);
        }

        public void AddItems(List<Review> items)
        {
            _reviewRepository.AddRange(items);
        }

        public void DeleteItem(Guid id)
        {
            _reviewRepository.Delete(id);
        }

        public void UpdateItem(Review item)
        {
            _reviewRepository.Update(item);
        }
    }
}
