using System;
using System.ComponentModel.DataAnnotations;

namespace CookBook.PL.Models
{
    public class CompositionViewModel: CompositionBaseViewModel
    {
        [Required(ErrorMessage ="Необходимо заполнить поле название ингредиента")]
        public string IngredientName { get; set; }
    }
}
