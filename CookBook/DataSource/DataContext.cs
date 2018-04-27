using System.Collections.Generic;
using System.Linq;

namespace DataSource
{
    public class DataContext
    {
        private List<T> GetDataFromXml<T>()
        {
            XmlLoad<List<T>> loader = new XmlLoad<List<T>>();
            return loader.LoadData("C:/Users/a2.pavlova/source/Task2_CookBook/CookBook/XmlAccess/" + typeof(T).Name + ".xml");
        }
        
        public List<T> GetList<T>() => GetDataFromXml<T>();

        public void AddDataToXml<T>(List<T> items) where T : class
        {
            if (items == null) return;
            var data = GetDataFromXml<T>();
            data.AddRange(items);
            XmlSaver.SaveData(items, "C:/Users/a2.pavlova/source/Task2_CookBook/CookBook/XmlAccess/" + typeof(T).Name + ".xml");
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
            XmlSaver.SaveData(data, "C:/Users/a2.pavlova/source/Task2_CookBook/CookBook/XmlAccess/" + typeof(T).Name + ".xml");
        }

        public void Delete<T>(T item) where T : class
        {
            if (item == null) return;
            var data = GetList<T>();
            data.Remove(item);
        }

        public void Update<T>(T item) where T : class
        {
            if (item == null) return;
            var data = GetList<T>();
            var updateItem = data.Where(x => x.Equals(item)).FirstOrDefault();
            if (updateItem == null) return;

            updateItem = item;
        }
    }
}
