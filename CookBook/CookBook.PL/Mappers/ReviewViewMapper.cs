using CookBook.PL.Models;
using CookBook.BLL.Models;

namespace CookBook.PL.Mappers
{
    internal class ReviewViewMapper
    {
        internal static ReviewModel ConvertReviewViewModelToReviewModel(ReviewViewModel reviewModel)
        {
            return new ReviewModel
            {
                Description = reviewModel.Description,
                UserId = reviewModel.UserId,
                RecipeId = reviewModel.RecipeId,
                CreationDate = reviewModel.CreationDate
            };
        }

        internal static ReviewViewModel ConvertReviewModelToReviewViewModel(ReviewModel review)
        {
            return new ReviewViewModel
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
