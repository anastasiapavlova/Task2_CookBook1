using System;
using System.ComponentModel.DataAnnotations;

namespace CookBook.PL.Models
{
    public class CompositionBaseViewModel
    { 
        public Guid Id { get; set; }
        public Guid RecipeId { get; set; }
        public Guid IngredientId { get; set; }
        [Required]
        [Range(1, 5000)]
        public int Quantity { get; set; }
    }
}