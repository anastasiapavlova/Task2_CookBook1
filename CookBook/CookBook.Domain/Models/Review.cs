using System;

namespace CookBook.Domain.Models
{
    public class Review
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid RecipeId { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        public Recipe Recipe { get; set; }
        public User User { get; set; }
    }
}
