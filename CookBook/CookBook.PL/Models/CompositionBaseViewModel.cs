using System;
using System.ComponentModel.DataAnnotations;

namespace CookBook.PL.Models
{
    public class CompositionBaseViewModel
    { 
        public Guid Id { get; set; }
        public Guid RecipeId { get; set; }
        public Guid IngredientId { get; set; }
        [Range(1, 5000)]
        [Required(ErrorMessage = "Amount must be between 1 and 5000 pounds")]
        public int Quantity { get; set; }
    }
}