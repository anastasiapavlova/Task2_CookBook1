using System.Collections.Generic;

namespace CookBook.Domain.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Composition> Composition { get; set; }
    }
}
