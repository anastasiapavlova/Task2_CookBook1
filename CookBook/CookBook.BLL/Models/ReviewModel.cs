using System;

namespace CookBook.BLL.Models
{
    public class ReviewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RecipeId { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
