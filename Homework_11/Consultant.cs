using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    public class Consultant : IEmployee
    {
        #region Поля
        public string Name { get; set; }

        public Bank Bank { get; set; }
        #endregion

        #region Конструктор
        public Consultant(string name, Bank bank)
        {
            Name = name;
            Bank = bank;
        }
        #endregion

        #region Методы
        /// <summary>
        /// Возвращает строку информации о клиенте под индексом
        /// </summary>
        /// <param name="index">Индекс клиента</param>
        /// <returns></returns>
        public virtual string PrintClient(int index)
        {
            return Bank.ClientsList[index].FirstName + " " + Bank.ClientsList[index].MiddleName + " " + Bank.ClientsList[index].LastName +
                " " + "******************" + " " + Bank.ClientsList[index].TelephoneNumber + " " + Bank.ClientsList[index].DateTime + " " +
                Bank.ClientsList[index].ChangeLog + " " + Bank.ClientsList[index].WhoChange + "\n";
        }
        /// <summary>
        /// Меняет телефонный номер клиента под определенным индексом заданным значением
        /// </summary>
        /// <param name="index">Индекс клиента</param>
        /// <param name="value">Значение</param>
        public void ChangeTelephoneNumber(int index, string value)
        {
            Bank.ClientsList[index].TelephoneNumber = Convert.ToInt64(value);
            Bank.ClientsList[index].DateTime = DateTime.Now;
            Bank.ClientsList[index].ChangeLog += $"On {DateTime.Now} Telephone Number was changed to {value}\n";
            Bank.ClientsList[index].WhoChange = Name;
        }
        #endregion
    }
}