using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CookBook.Domain
{
    public class DataContext
    {
        private readonly string _dataLocation;

        public DataContext()
        {
            _dataLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\CookBook.Domain\\Source\\";
            if (Directory.Exists(_dataLocation)) return;
            Directory.CreateDirectory(_dataLocation);
        }

        private List<T> GetDataFromXml<T>()
        {
            XmlLoad<List<T>> loader = new XmlLoad<List<T>>();
            return loader.LoadData(_dataLocation + typeof(T).Name + ".xml");
        }
        
        public List<T> GetList<T>() => GetDataFromXml<T>();

        public void AddRange<T>(List<T> items) where T : class
        {
            if (items == null) return;
            var data = GetDataFromXml<T>();
            data.AddRange(items);
            XmlSaver.SaveData(items, _dataLocation + typeof(T).Name + ".xml");
        }

        public T Get<T>(T item) where T : class
        {
            if (item == null) return default(T);
            var data = GetDataFromXml<T>();
            return data.FirstOrDefault(x => x.Equals(item));
        }
        public void Add<T>(T item) where T : class
        {
            if (item == null) return;
            var data = GetDataFromXml<T>();
            data.Add(item);
            XmlSaver.SaveData(data, _dataLocation + typeof(T).Name + ".xml");
        }

        public void Delete<T>(T item) where T : class
        {
            if (item == null) return;
            var data = GetList<T>();
            data.Remove(item);
            XmlSaver.SaveData(data, _dataLocation + typeof(T).Name + ".xml");
        }

        public void Update<T>(T updateItem, T item) where T : class
        {
            if (item == null) return;
            var data = GetList<T>();
            if (updateItem == null) return;
            data.Remove(updateItem);
            data.Add(item);
            XmlSaver.SaveData(data, _dataLocation + typeof(T).Name + ".xml");
        }
    }
}
