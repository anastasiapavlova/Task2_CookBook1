using System.Collections.Generic;

namespace DataSource.Models
{
    public class RecipeDataModel
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public List<int> MarksId { get; set; }
        public List<int> IngredientsId { get; set; }
    }
}
