﻿namespace CookBook.Domain.Models
{
    public class Composition
    {
        public int Id { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Composition composition = obj as Composition;
            if (composition as Composition == null)
                return false;

            return composition.Id == this.Id && composition.IngredientId == this.IngredientId && composition.Quantity == this.Quantity;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
