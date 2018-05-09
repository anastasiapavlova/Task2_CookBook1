using System;

namespace CookBook.BLL.Models
{
    public class CompositionModel
    {
        public CompositionModel()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public Guid RecipeId { get; set; }
        public Guid IngredientId { get; set; }
        public string IngredientName { get; set; }
        public int Quantity { get; set; }
    }
}
