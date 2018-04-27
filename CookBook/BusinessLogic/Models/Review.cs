using System;

namespace BusinessLogic.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
