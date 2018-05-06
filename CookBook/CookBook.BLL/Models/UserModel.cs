﻿using CookBook.BLL.Enums;

namespace CookBook.BLL.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public AccountTypes Type { get; set; }
    }
}