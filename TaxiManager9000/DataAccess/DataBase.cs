using Newtonsoft.Json;
using TaxiManager9000.DataAccess.Interface;
using TaxiManager9000.Domain.Entities;

namespace TaxiManager9000.DataAccess
{
    public abstract class Database<T> : IDatabase<T> where T : BaseEntity
    {
        protected List<T> _items;
        private readonly string _fileLocation;
        private int _currentId = 0;

        public Database()
        {
            _fileLocation = $@"{Directory.GetCurrentDirectory()}\{typeof(T).Name}.json";
            if (!File.Exists(_fileLocation))
            {
                var stream = File.Create(_fileLocation);
                stream.Close();
            }

                _items = ReadFromFile();
                _currentId = _items.OrderBy(x => x.Id).LastOrDefault()?.Id ?? 0;
            
        }

        private List<T> ReadFromFile()
        {
            List<T> items = new List<T>();
            using (StreamReader sr = new StreamReader(_fileLocation))
            {
                string json = sr.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<T>>(json);
            }

            return items ?? new List<T>();
        }

        public void Insert(T item)
        {
            T itemToInsert = AutoIncrementId(item);

            _items.Add(itemToInsert);
            WriteToFile();
        }

        private void WriteToFile()
        {
            using (StreamWriter sw = new StreamWriter(_fileLocation))
            {
                string json = JsonConvert.SerializeObject(_items);
                sw.Write(json);
                sw.Flush();
            }
        }

        public void Remove(T item)
        {
            _items.Remove(item);
            WriteToFile();
        }

        public void Update(T item)
        {
            WriteToFile();
        }

        public List<T> GetAll()
        {
            return _items;
        }

        protected T AutoIncrementId(T item)
        {
            int currentId = 0;

            if (_items.Count > 0)
            {
                currentId = _items.OrderByDescending(x => x.Id).First().Id;
            }

            item.Id = ++currentId;

            return item;
        }
    }
}
