using System;
using Ninject;
using System.Linq;
using CookBook.BLL.Models;
using CookBook.BLL.Mappers;
using CookBook.Domain.Models;
using CookBook.BLL.Interfaces;
using CookBook.DAL.Interfaces;
using System.Collections.Generic;

namespace CookBook.BLL.Services
{
    public class ReviewService : IReviewService
    {
        [Inject]
        public IReviewRepository ReviewRepository { get; set; }
        
        public List<ReviewModel> GetList()
        {
            var resultList = ReviewRepository.GetList();

            return resultList.Select(ReviewMapper.ConvertReviewToReviewModel).ToList();
        }

        public void AddItem(Review item)
        {
            ReviewRepository.Add(item);
        }

        public void AddItems(List<Review> items)
        {
            ReviewRepository.AddRange(items);
        }

        public void DeleteItem(Guid id)
        {
            ReviewRepository.Delete(id);
        }

        public void UpdateItem(Review item)
        {
            ReviewRepository.Update(item);
        }
    }
}
