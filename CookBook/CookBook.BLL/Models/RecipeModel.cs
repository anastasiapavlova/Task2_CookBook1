using System;
using CookBook.BLL.Enums;
using System.Collections.Generic;

namespace CookBook.BLL.Models
{
    public class RecipeModel
    {
        public Guid Id { get; set; }
        public CategoryTypes Category { get; set; }
        public string Name { get; set; }
        public Guid UserId { get; set; }
        public List<CompositionModel> Composition { get; set; }
        public List<ReviewModel> Review { get; set; }
        public UserModel User { get; set; }
    }
}
