using System.ComponentModel.DataAnnotations;

namespace CookBook.PL.Models
{
    public class CompositionViewModel: CompositionBaseViewModel
    {
        [Required(ErrorMessage = "Ingredient name is required")]
        public string IngredientName { get; set; }
    }
}
