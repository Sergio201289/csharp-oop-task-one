using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    public class Bank
    {
        #region Поля
        public string Name { get; set; }

        public List<Client> ClientsList { get; set; }
        #endregion

        #region Конструктор
        public Bank(string name)
        {
            Name = name;
            ClientsList = new List<Client>();
        }
        #endregion

        #region Методы
        /// <summary>
        /// Распаковывает коллекцию клиентов из JSON файла
        /// </summary>
        public void Open()
        {
            ClientsList = JsonConvert.DeserializeObject<List<Client>>(File.ReadAllText($"Clients.json"));
        }
        /// <summary>
        /// Сохраняет коллекцию клиентов в JSON файл
        /// </summary>
        public void Save()
        {
            File.WriteAllText($"Clients.json", JsonConvert.SerializeObject(ClientsList));
        }
        #endregion
    }
}