using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CookBook.Domain.Enums;

namespace CookBook.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        public AccountTypes Type { get; set; }
        [Required]
        public string Password { get; set; }

        public List<Recipe> Recipe { get; set; }
        public List<Review> Review { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            User user = obj as User;
            if (user as User == null)
                return false;

            return user.Id == this.Id && user.Login == this.Login && user.Type == this.Type &&
                   user.Password == this.Password;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
