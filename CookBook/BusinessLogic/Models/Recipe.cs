using System.Collections.Generic;

namespace BusinessLogic.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public List<int> ReviewsId { get; set; }
        public List<int> CompositionsId { get; set; }
    }
}
