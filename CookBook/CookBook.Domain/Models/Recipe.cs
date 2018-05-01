using CookBook.Domain.Enums;

namespace CookBook.Domain.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public CategoryTypes Category { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Recipe recipe = obj as Recipe;
            if (recipe as Recipe == null)
                return false;

            return recipe.Id == this.Id && recipe.Category == this.Category && recipe.Name == this.Name &&
                   recipe.UserId == this.UserId;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
