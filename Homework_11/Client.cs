using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    public class Client
    {
        #region Поля
        private long telephoneNumber;

        private string serialOfDocument;

        private string firstName;

        private string middleName;

        private string lastName;

        private DateTime dateTime;

        private string changeLog;

        private string whoChange;
        #endregion

        #region Свойства
        [JsonProperty("FirstName")]
        public string FirstName { get { return firstName; } set { firstName = value; } }
        [JsonProperty("MiddleName")]
        public string MiddleName { get { return middleName; } set { middleName = value; } }
        [JsonProperty("LastName")]
        public string LastName { get { return lastName; } set { lastName = value; } }
        [JsonProperty("DateTime")]
        public DateTime DateTime { get { return dateTime; } set { dateTime = value; } }
        [JsonProperty("ChangeLog")]
        public string ChangeLog { get { return changeLog; } set { changeLog = value; } }
        [JsonProperty("WhoChange")]
        public string WhoChange { get { return whoChange; }set { whoChange = value; } }
        [JsonProperty("SerialOfDocument")]
        public string SerialOfDocument { get { return serialOfDocument; } set { serialOfDocument = value; } }
        [JsonProperty("TelephoneNumber")]
        public long TelephoneNumber 
        {
            //Возвращает значение телефонного номера и устанавливает его только в том случае, если длинна больше 10 символов
            get
            {
                return telephoneNumber;
            }
            set
            {
                if (value.ToString().Length >= 10) telephoneNumber = value;
            }
        }
        #endregion

        #region Конструктор
        public Client(string firstName, string middleName, string lastName, long telephoneNumber, string serialOfDocument)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            TelephoneNumber = telephoneNumber;
            SerialOfDocument = serialOfDocument;
        }
        #endregion
    }
}