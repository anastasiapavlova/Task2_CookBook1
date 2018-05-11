using System;

namespace CookBook.PL.Models
{
    public class ReviewViewModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid RecipeId { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
