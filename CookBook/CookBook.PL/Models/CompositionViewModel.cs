using System;
namespace CookBook.Pl.Models
{
    public class CompositionViewModel
    {
        public Guid Id { get; set; }
        public Guid RecipeId { get; set; }
        public Guid IngredientId { get; set; }
        public int Quantity { get; set; }
        public string IngredientName { get; set; }
    }
}
