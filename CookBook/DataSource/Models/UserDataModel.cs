using DataSource.Enums;

namespace DataSource.Models
{
    public class UserDataModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public AccountType Type { get; set; }
        public string Password { get; set; }
    }
}
