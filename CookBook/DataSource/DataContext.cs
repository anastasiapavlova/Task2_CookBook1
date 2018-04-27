using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
    public class DataContext
    {

        private List<T> GetDataFromXml<T>()
        {
            XmlLoad<List<T>> loader = new XmlLoad<List<T>>();
            return loader.LoadData("C:/Users/a2.pavlova/source/Task2_CookBook/CookBook/XmlAccess/xmlData.xml");
        }

        public List<T> GetList<T>() => GetDataFromXml<T>();

        public T Get<T>(T item) where T : class
        {
            if (item == null) return default(T);

            var data = GetDataFromXml<T>();

            //add search by ID with custom attribute
            //but now we can do like this =(
            return data.FirstOrDefault(x => x.Equals(item));
        }
        public void Add<T>(T item) where T : class
        {
            if (item == null) return;

            var data = GetDataFromXml<T>();
            data.Add(item);
            XmlSaver.SaveData(data, "C:/Users/a2.pavlova/source/Task2_CookBook/CookBook/XmlAccess/xmlData.xml");
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
