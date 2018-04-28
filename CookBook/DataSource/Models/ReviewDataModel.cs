using System;

namespace DataSource.Models
{
    public class ReviewDataModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime ReviewDate { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            ReviewDataModel m = obj as ReviewDataModel;
            if (m as ReviewDataModel == null)
                return false;

            return m.Id == this.Id && m.UserId == this.UserId && m.Description == this.Description &&
                   m.ReviewDate == this.ReviewDate;
        }
    }
}
