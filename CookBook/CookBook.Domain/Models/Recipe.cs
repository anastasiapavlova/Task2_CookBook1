using System;
using CookBook.Domain.Enums;
using System.Collections.Generic;

namespace CookBook.Domain.Models
{
    public class Recipe
    {
        public Recipe()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public CategoryTypes Category { get; set; }
        public string Name { get; set; }
        public Guid UserId { get; set; }
        
        public List<Composition> Composition { get; set; }
        public List<Review> Review { get; set; }
        public User User { get; set; }
    }
}
