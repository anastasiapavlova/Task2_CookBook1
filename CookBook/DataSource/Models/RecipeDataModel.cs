using System.Collections.Generic;

namespace DataSource.Models
{
    public class RecipeDataModel
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public List<int> ReviewsId { get; set; }
        public List<int> CompositionsId { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            RecipeDataModel m = obj as RecipeDataModel;
            if (m as RecipeDataModel == null)
                return false;

            return m.Id == this.Id && m.Category == this.Category && m.Name == this.Name && 
                   m.UserId == this.UserId && m.ReviewsId == this.ReviewsId 
                   && m.CompositionsId == this.CompositionsId;
        }
    }
}
