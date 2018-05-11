using CookBook.BLL.Models;
using CookBook.Domain.Models;

namespace CookBook.BLL.Mappers
{
    internal class IngredientMapper
    {
        internal static Ingredient ConvertIngredientModelToIngredient(IngredientModel ingredientModel)
        {
            return new Ingredient
            {
                Name = ingredientModel.Name
            };
        }

        internal static IngredientModel ConvertIngredientToIngredientModel(Ingredient ingredientModel)
        {
            return new IngredientModel
            {
                Id = ingredientModel.Id,
                Name = ingredientModel.Name
            };
        }
    }
}
