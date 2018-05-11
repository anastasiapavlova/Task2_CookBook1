using System;
using CookBook.BLL.Enums;
using CookBook.Pl.Models;
using System.Collections.Generic;

namespace CookBook.PL.Models
{
    public class RecipeViewModel
    {
        public Guid Id { get; set; }
        public CategoryTypes Category { get; set; }
        public string Name { get; set; }
        public Guid UserId { get; set; }
        public List<CompositionViewModel> Composition { get; set; }
        public List<ReviewViewModel> Review { get; set; }
        public UserViewModel User { get; set; }
    }
}
