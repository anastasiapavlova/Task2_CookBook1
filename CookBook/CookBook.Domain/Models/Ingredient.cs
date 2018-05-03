using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookBook.Domain.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Composition> Composition { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Ingredient ingredient = obj as Ingredient;
            if (ingredient as Ingredient == null)
                return false;

            return ingredient.Id == this.Id && ingredient.Name == this.Name;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
