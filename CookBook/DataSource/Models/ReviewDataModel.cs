using System;

namespace DataSource.Models
{
    public class ReviewDataModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
