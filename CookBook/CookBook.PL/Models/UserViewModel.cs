using System;
using CookBook.BLL.Enums;

namespace CookBook.PL.Models
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public AccountTypes Type { get; set; }
    }
}
