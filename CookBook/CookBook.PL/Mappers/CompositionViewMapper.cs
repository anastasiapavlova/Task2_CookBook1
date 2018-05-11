using CookBook.Pl.Models;
using CookBook.BLL.Models;

namespace CookBook.PL.Mappers
{
    internal class CompositionViewMapper
    {
        internal static CompositionModel ConvertCompositonViewModelToCompositionModel(CompositionViewModel compositionModel)
        {
            return new CompositionModel
            {
                IngredientId = compositionModel.IngredientId,
                Quantity = compositionModel.Quantity,
                RecipeId = compositionModel.RecipeId
            };
        }

        internal static CompositionViewModel ConvertCompositonModelToCompositionViewModel(CompositionModel composition)
        {
            return new CompositionViewModel
            {
                Id = composition.Id,
                IngredientId = composition.IngredientId,
                Quantity = composition.Quantity,
                RecipeId = composition.RecipeId,
                IngredientName = composition.IngredientName
            };
        }
    }
}
