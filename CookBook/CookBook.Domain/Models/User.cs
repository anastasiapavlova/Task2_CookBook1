using System.Collections.Generic;
using CookBook.Domain.Enums;

namespace CookBook.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public AccountTypes Type { get; set; }
        public string Password { get; set; }

        public List<Recipe> Recipe { get; set; }
        public List<Review> Review { get; set; }
    }
}
