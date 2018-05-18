﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CookBook.PL.Models
{
    public class IndexViewModel
    {
        public IEnumerable<RecipeViewModel> Recipes { get; set; }
        public PageInfo PageInfo { get; set; }
    }

    public class PageInfo
    {
        public int PageNumber { get; set; } // номер текущей страницы
        public int PageSize { get; set; } // кол-во объектов на странице
        public int TotalItems { get; set; } // всего объектов
        public int TotalPages  // всего страниц
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / PageSize); }
        }
    }
}