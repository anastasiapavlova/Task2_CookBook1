using System.Linq;
using CookBook.PL.Models;
using CookBook.BLL.Models;
using CookBook.Pl.Mappers;

namespace CookBook.PL.Mappers
{
    internal class RecipeViewMapper
    {
        internal static RecipeModel ConvertRecipeViewModelToRecipeModel(RecipeViewModel recipeModel)
        {
            return new RecipeModel
            {
                Name = recipeModel.Name,
                Composition = recipeModel.Composition?.Select(CompositionViewMapper.ConvertCompositonViewModelToCompositionModel).ToList(),
                Category = recipeModel.Category,
                Review = recipeModel.Review?.Select(ReviewViewMapper.ConvertReviewViewModelToReviewModel).ToList(),
                User = UserViewMapper.ConvertUserViewModelToUserModel(recipeModel.User)
            };
        }

        internal static RecipeViewModel ConvertRecipeModelToRecipeViewModel(RecipeModel recipe)
        {
            return new RecipeViewModel
            {
                Id = recipe.Id,
                Name = recipe.Name,
                Composition = recipe.Composition?.Select(CompositionViewMapper.ConvertCompositonModelToCompositionViewModel).ToList(),
                Category = recipe.Category,
                Review = recipe.Review?.Select(ReviewViewMapper.ConvertReviewModelToReviewViewModel).ToList(),
                UserId = recipe.UserId
            };
        }
    }
}
