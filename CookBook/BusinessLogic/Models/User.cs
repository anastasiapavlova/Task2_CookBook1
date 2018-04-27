using BusinessLogic.Enums;

namespace BusinessLogic.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public AccountType Type { get; set; }
    }
}
