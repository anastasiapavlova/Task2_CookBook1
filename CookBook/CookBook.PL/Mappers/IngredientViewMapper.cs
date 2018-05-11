using CookBook.PL.Models;
using CookBook.BLL.Models;

namespace CookBook.PL.Mappers
{
    internal class IngredientViewMapper
    {
        internal static IngredientModel ConvertIngredientViewModelToIngredientModel(IngredientViewModel ingredientModel)
        {
            return new IngredientModel
            {
                Name = ingredientModel.Name
            };
        }

        internal static IngredientViewModel ConvertIngredientModelToIngredientViewModel(IngredientModel ingredientModel)
        {
            return new IngredientViewModel
            {
                Id = ingredientModel.Id,
                Name = ingredientModel.Name
            };
        }
    }
}
