namespace BusinessLogic.Models
{
    public class User
    {
        public User(int id, string name, int accountType)
        {
            Id = id;
            Name = name;
            AccountType = accountType;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int AccountType { get; set; }
    }
}
