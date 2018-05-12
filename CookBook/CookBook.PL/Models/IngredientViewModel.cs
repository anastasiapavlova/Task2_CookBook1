using System;
using System.ComponentModel.DataAnnotations;

namespace CookBook.PL.Models
{
    public class IngredientViewModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
