using System;

namespace CookBook.Domain.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RecipeId { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        public Recipe Recipe { get; set; }
        public User User { get; set; }
    }
}
