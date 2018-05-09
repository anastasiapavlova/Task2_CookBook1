using CookBook.BLL.Models;
using CookBook.Domain.Models;


namespace CookBook.BLL.Mappers
{
    internal class ReviewMapper
    {
        internal static Review ConvertReviewModelToReview(ReviewModel reviewModel)
        {
            return new Review
            {
                Id = reviewModel.Id,
                Description = reviewModel.Description,
                UserId = reviewModel.UserId,
                RecipeId = reviewModel.RecipeId,
                CreationDate = reviewModel.CreationDate
            };
        }

        internal static ReviewModel ConvertReviewToReviewModel(Review review)
        {
            return new ReviewModel
            {
                Id = review.Id,
                Description = review.Description,
                UserId = review.UserId,
                RecipeId = review.RecipeId,
                CreationDate = review.CreationDate
            };
        }
    }
}
