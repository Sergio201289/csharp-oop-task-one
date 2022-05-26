using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    public class Manager : Consultant
    {
        #region Констурктор
        public Manager(string name, Bank bank) : base(name, bank) { }
        #endregion

        #region Методы
        /// <summary>
        /// Добавляет клиента в коллекцию банка
        /// </summary>
        /// <param name="client"></param>
        public void AddClient(Client client)
        {
            Bank.ClientsList.Add(client);
        }
        /// <summary>
        /// Меняет имя клиента под индексом на новое значение
        /// </summary>
        /// <param name="index">Индекс клиента</param>
        /// <param name="firstName">Новое значение</param>
        public void ChangeFirstName(int index, string firstName)
        {
            Bank.ClientsList[index].FirstName = firstName;
            Bank.ClientsList[index].DateTime = DateTime.Now;
            Bank.ClientsList[index].ChangeLog += $"On {DateTime.Now} First Name was changed to {firstName}\n";
            Bank.ClientsList[index].WhoChange = Name;
        }
        /// <summary>
        /// Меняет Отчество клиента под индексом на новое значение
        /// </summary>
        /// <param name="index">Индекс клиента</param>
        /// <param name="middleName">Новое значение</param>
        public void ChangeMiddleName(int index, string middleName)
        {
            Bank.ClientsList[index].MiddleName = middleName;
            Bank.ClientsList[index].DateTime = DateTime.Now;
            Bank.ClientsList[index].ChangeLog += $"On {DateTime.Now} Middle Name was changed to {middleName}\n";
            Bank.ClientsList[index].WhoChange = Name;
        }
        /// <summary>
        /// Меняет Фамилию клиента под индексом на новое значение
        /// </summary>
        /// <param name="index">Индекс клиента</param>
        /// <param name="lastName">Новое значение</param>
        public void ChangeLastName (int index, string lastName)
        {
            Bank.ClientsList[index].LastName = lastName;
            Bank.ClientsList[index].DateTime = DateTime.Now;
            Bank.ClientsList[index].ChangeLog += $"On {DateTime.Now} Last Name was changed to {lastName}\n";
            Bank.ClientsList[index].WhoChange = Name;
        }
        /// <summary>
        /// Меняет серию паспорта клиента под индекссом на новое значение
        /// </summary>
        /// <param name="index">Индекс клиента</param>
        /// <param name="serialOfDocument">Новое значение</param>
        public void ChangeSerialOfDocument(int index, string serialOfDocument)
        {
            Bank.ClientsList[index].SerialOfDocument = serialOfDocument;
            Bank.ClientsList[index].DateTime = DateTime.Now;
            Bank.ClientsList[index].ChangeLog += $"On {DateTime.Now} Serial Of Document was changed to {serialOfDocument}\n";
            Bank.ClientsList[index].WhoChange = Name;
        }
        /// <summary>
        /// Возвращает строку с информацией о клиенте под индексом
        /// </summary>
        /// <param name="index">Индекс клиента</param>
        /// <returns></returns>
        public override string PrintClient(int index)
        {
            return Bank.ClientsList[index].FirstName + " " + Bank.ClientsList[index].MiddleName + " " + Bank.ClientsList[index].LastName +
                " " + Bank.ClientsList[index].SerialOfDocument + " " + Bank.ClientsList[index].TelephoneNumber.ToString() + " " + Bank.ClientsList[index].DateTime + " " +
                Bank.ClientsList[index].ChangeLog + " " + Bank.ClientsList[index].WhoChange + "\n";
        }
        #endregion
    }
}