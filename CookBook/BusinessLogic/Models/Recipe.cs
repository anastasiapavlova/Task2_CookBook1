using System.Collections.Generic;

namespace BusinessLogic.Models
{
    public class Recipe
    {
        public Recipe()
        {
        }

        public Recipe(int id, string category, string name, int authorId, List<int> marksId, List<int> ingredientsId)
        {
            Id = id;
            Category = category;
            Name = name;
            AuthorId = authorId;
            MarksId = marksId;
            IngredientsId = ingredientsId;
        }

        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public List<int> MarksId { get; set; }
        public List<int> IngredientsId { get; set; }
    }
}
