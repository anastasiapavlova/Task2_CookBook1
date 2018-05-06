using CookBook.BLL.Enums;
using System.Collections.Generic;

namespace CookBook.BLL.Models
{
    public class RecipeModel
    {
        public int Id { get; set; }
        public CategoryTypes Category { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public List<IngredientModel> Ingredients { get; set; }
    }
}
