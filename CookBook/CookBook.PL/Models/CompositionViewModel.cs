using System.ComponentModel.DataAnnotations;

namespace CookBook.PL.Models
{
    public class CompositionViewModel: CompositionBaseViewModel
    {
        [Required]
        public string IngredientName { get; set; }
    }
}
