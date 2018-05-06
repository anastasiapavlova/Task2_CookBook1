﻿namespace CookBook.BLL.Models
{
    public class CompositionModel
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }
    }
}