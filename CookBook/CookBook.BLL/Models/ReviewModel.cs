using System;

namespace CookBook.BLL.Models
{
    public class ReviewModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid RecipeId { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
