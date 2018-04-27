﻿using System.Collections.Generic;
using BusinessLogic.Interfaces;
using DataAccess.Repositories;

namespace BusinessLogic.Services
{
    public class MainService<T> : IService<T>
        where T : class
    {
        public List<T> GetList()
        {
            var repository = new Repository<T>();  
            return repository.GetList();
        }

        public void AddItem(T item)
        {
            var repository = new Repository<T>();
            repository.Add(item);
        }

        public void AddItems(List<T> items)
        {
            var repository = new Repository<T>();
            repository.AddRange(items);
        }

        public void DeleteItem(T item)
        {
            var repository = new Repository<T>();
            repository.Delete(item);
        }

        public void UpdateItem(T item)
        {
            var repository = new Repository<T>();
            repository.Update(item);
        }
    }
}
