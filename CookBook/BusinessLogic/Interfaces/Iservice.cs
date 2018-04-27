using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models;

namespace BusinessLogic.Interfaces
{
    public interface IService<T>
    {
        List<T> GetList();
        void AddItem(T item);
        void AddItems(List<T> items);
    }
}
