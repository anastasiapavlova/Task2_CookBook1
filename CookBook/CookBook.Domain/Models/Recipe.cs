using System.Collections.Generic;
using CookBook.Domain.Enums;

namespace CookBook.Domain.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public CategoryTypes Category { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        
        public List<Composition> Composition { get; set; }
        public List<Review> Review { get; set; }
        public User User { get; set; }
    }
}
