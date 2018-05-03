using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookBook.Domain.Models
{
    public class Composition
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }

        public Ingredient Ingredient { get; set; }
        public Recipe Recipe { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Composition composition = obj as Composition;
            if (composition as Composition == null)
                return false;
            return composition.Id == this.Id && composition.IngredientId == this.IngredientId && composition.Quantity == this.Quantity;
            //return composition.Id == this.Id && composition.RecipeId == this.RecipeId && composition.IngredientId == this.IngredientId && composition.Quantity == this.Quantity;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
