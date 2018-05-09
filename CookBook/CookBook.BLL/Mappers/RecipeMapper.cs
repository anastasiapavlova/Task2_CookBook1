using CookBook.BLL.Models;
using CookBook.Domain.Enums;
using CookBook.Domain.Models;
using System.Linq;

namespace CookBook.BLL.Mappers
{
    internal class RecipeMapper
    {
        internal static Recipe ConvertRecipeModelToRecipe(RecipeModel recipeModel)
        {
            return new Recipe
            {
                Id = recipeModel.Id,
                Name = recipeModel.Name,
                Composition = recipeModel.Composition.Select(CompositionMapper.ConvertCompositonModelToComposition).ToList(),
                Category = (CategoryTypes)recipeModel.Category,
                Review = recipeModel.Review.Select(ReviewMapper.ConvertReviewModelToReview).ToList(),
                User = UserMapper.ConvertUserModelToUser(recipeModel.User)
            };
        }

        internal static RecipeModel ConvertRecipeToRecipeModel(Recipe recipe)
        {
            return new RecipeModel
            {
                Id = recipe.Id,
                Name = recipe.Name,
                Composition = recipe.Composition?.Select(CompositionMapper.ConvertCompositonToCompositionModel).ToList(),
                Category = (Enums.CategoryTypes)recipe.Category,
                Review = recipe.Review?.Select(ReviewMapper.ConvertReviewToReviewModel).ToList(),
                User = UserMapper.ConvertUserToUserModel(recipe.User)
            };
        }
    }
}
