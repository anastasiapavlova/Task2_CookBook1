﻿using CookBook.BLL.Interfaces;
using CookBook.DAL.Repositories;
using CookBook.Domain.Models;
using System.Collections.Generic;

namespace CookBook.BLL.Services
{
    public class RecipeService : IRecipeService
    {
        private RecipeRepository repository;

        public RecipeService()
        {
            repository = new RecipeRepository();
        }

        public List<Recipe> GetList()
        {
            return repository.GetList();
        }

        public void AddItem(Recipe item)
        {
            repository.Add(item);
        }

        public void AddItems(List<Recipe> items)
        {
            repository.AddRange(items);
        }

        public void DeleteItem(int id)
        {
            repository.Delete(id);
        }

        public void UpdateItem(Recipe item)
        {
            repository.Update(item);
        }
    }
}
