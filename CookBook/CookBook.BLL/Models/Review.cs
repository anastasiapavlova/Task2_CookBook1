using System;

namespace CookBook.BLL.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
