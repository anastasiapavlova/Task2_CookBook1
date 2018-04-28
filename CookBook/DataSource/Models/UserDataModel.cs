using DataSource.Enums;

namespace DataSource.Models
{
    public class UserDataModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public AccountType Type { get; set; }
        public string Password { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            UserDataModel m = obj as UserDataModel;
            if (m as UserDataModel == null)
                return false;

            return m.Id == this.Id && m.Login == this.Login && m.Type == this.Type &&
                   m.Password == this.Password;
        }
    }
}
