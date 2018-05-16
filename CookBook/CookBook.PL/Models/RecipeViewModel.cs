using System;
using CookBook.BLL.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CookBook.PL.Models
{
    public class RecipeViewModel
    {
        public Guid Id { get; set; }
        public CategoryTypes Category { get; set; }

        [Required]
        public string Name { get; set; }
        public Guid UserId { get; set; }
        public List<CompositionViewModel> Composition { get; set; }
        public List<ReviewViewModel> Review { get; set; }
        public UserViewModel User { get; set; }
    }
}
