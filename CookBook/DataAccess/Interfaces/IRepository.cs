﻿using System.Collections.Generic;

namespace DataAccess.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetList();
        void AddRange(List<T> items);
        T Get(T item);
        void Update(T updateItem, T item);
        void Delete(T item);
        void Add(T item);
    }
}
