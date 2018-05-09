using System;
using System.Collections.Generic;

namespace CookBook.Domain.Models
{
    public class Ingredient
    {
        public Ingredient()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Composition> Composition { get; set; }
    }
}
