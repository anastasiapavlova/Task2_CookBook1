using DataAccess.Interfaces;
using DataSource;
using System;
using System.Collections.Generic;

namespace DataAccess.Repositories
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        public void Add(T item)
        {
            var dataContext = new DataContext();
            dataContext.Add<T>(item);
        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

        public List<T> GetList()
        {
            throw new NotImplementedException();
        }

        public T List()
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
