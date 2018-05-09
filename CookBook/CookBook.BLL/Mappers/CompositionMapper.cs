using CookBook.BLL.Models;
using CookBook.Domain.Models;

namespace CookBook.BLL.Mappers
{
    internal class CompositionMapper
    {
        internal static Composition ConvertCompositonModelToComposition(CompositionModel compositionModel)
        {
            return new Composition
            {
                IngredientId = compositionModel.IngredientId,
                Quantity = compositionModel.Quantity,
                RecipeId = compositionModel.RecipeId
            };
        }

        internal static CompositionModel ConvertCompositonToCompositionModel(Composition composition)
        {
            return new CompositionModel
            {
                Id = composition.Id,
                IngredientId = composition.IngredientId,
                IngredientName = composition.Ingredient?.Name,
                Quantity = composition.Quantity,
                RecipeId = composition.RecipeId
            };
        }
    }
}
