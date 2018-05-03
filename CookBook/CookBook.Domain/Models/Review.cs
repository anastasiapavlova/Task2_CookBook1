using System;
using System.ComponentModel.DataAnnotations;

namespace CookBook.Domain.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RecipeId { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        public Recipe Recipe { get; set; }
        public User User { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Review m = obj as Review;
            if (m as Review == null)
                return false;

            return m.Id == this.Id && m.UserId == this.UserId && m.Description == this.Description &&
                   m.CreationDate == this.CreationDate;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
