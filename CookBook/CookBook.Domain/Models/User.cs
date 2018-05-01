using CookBook.Domain.Enums;

namespace CookBook.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public AccountTypes Type { get; set; }
        public string Password { get; set; }

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
