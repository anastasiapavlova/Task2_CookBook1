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
    }
}
