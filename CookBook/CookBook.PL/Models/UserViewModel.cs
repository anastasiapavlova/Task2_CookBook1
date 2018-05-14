using System;
using CookBook.BLL.Enums;
using System.ComponentModel.DataAnnotations;

namespace CookBook.PL.Models
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        [StringLength(10)]
        public string Login { get; set; }
        public AccountTypes Type { get; set; }
        public string Password { get; set; }
    }
}
