using CookBook.BLL.Enums;
using System;

namespace CookBook.BLL.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public AccountTypes Type { get; set; }
    }
}
