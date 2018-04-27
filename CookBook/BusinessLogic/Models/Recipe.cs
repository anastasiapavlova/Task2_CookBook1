using System.Collections.Generic;

namespace BusinessLogic.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Composition> Compositions { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}
