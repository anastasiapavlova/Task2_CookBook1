using System;
using CookBook.Domain.Enums;
using System.Collections.Generic;

namespace CookBook.Domain.Models
{
    public class User
    {
        public User()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Login { get; set; }
        public AccountTypes Type { get; set; }
        public string Password { get; set; }

        public List<Recipe> Recipe { get; set; }
        public List<Review> Review { get; set; }
    }
}
