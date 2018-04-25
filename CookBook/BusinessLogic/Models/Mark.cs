namespace BusinessLogic.Models
{
    public class Mark
    {
        public Mark(int id, int recipeId, int value, string author)
        {
            Id = id;
            RecipeId = recipeId;
            Value = value;
            Author = author;
        }
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public int Value { get; set; }
        public string Author { get; set; }
    }
}
