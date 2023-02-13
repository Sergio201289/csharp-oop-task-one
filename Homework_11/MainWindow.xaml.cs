using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Homework_11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bank bank = new Bank("");
        AddWindow addWindow;
        EditClientByManager editClientByManager;
        EditClientByConsultant editClientByConsultant;
        Consultant consultant;
        Manager manager;
        bool flagManager;
        public MainWindow()
        {
            InitializeComponent();
            consultant = new Consultant("", bank);
            manager = new Manager("", bank);
            ChangeCount();
            AddButton.Visibility = Visibility.Hidden;
            OpenButton.Visibility = Visibility.Hidden;
            SaveButton.Visibility = Visibility.Hidden;
            EditButton.Visibility = Visibility.Hidden;
            PrintButton.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// Изменение интерфейса программы в ответ на смену сотрудника в элементе выбора ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Employee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string element = ((TextBlock)Employee.SelectedItem).Text;
            if (element == "Консультант")
            {
                flagManager = false;
                EditButton.Visibility = Visibility.Visible;
                PrintButton.Visibility = Visibility.Visible;
                AddButton.Visibility = Visibility.Hidden;
                OpenButton.Visibility = Visibility.Hidden;
                SaveButton.Visibility = Visibility.Hidden;
            }
            else
            {
                flagManager = true;
                EditButton.Visibility = Visibility.Visible;
                PrintButton.Visibility = Visibility.Visible;
                AddButton.Visibility = Visibility.Visible;
                OpenButton.Visibility = Visibility.Visible;
                SaveButton.Visibility = Visibility.Visible;
            }
        }
        /// <summary>
        /// Вызов окна добавления клиента по нажатию кнопки 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            addWindow = new AddWindow(manager);
            addWindow.AddOKButton.Click += ChangeCount;
            addWindow.Show();
        }
        /// <summary>
        /// Отслеживание изменения количества записей в коллекции клиентов банка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeCount(object sender, RoutedEventArgs e)
        {
            Count.Text = "Количество записей = " + bank.ClientsList.Count;
        }
        /// <summary>
        /// Отслеживание изменения количества записей в коллекции клиентов банка
        /// </summary>
        private void ChangeCount()
        {
            Count.Text = "Количество записей = " + bank.ClientsList.Count;
        }
        /// <summary>
        /// запуск метода сохранения коллекции клиентов по нажатию кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            bank.Save();
        }
        /// <summary>
        /// запуск метода открытия коллекции клиентов по нажатию кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            bank.Open();
            ChangeCount();
        }
        /// <summary>
        /// вызов окна и распечатки коллекции клиентов в зависимости от сотрудника по нажатию кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            PrintClient printClient = new PrintClient();
            printClient.Show();
            if (flagManager)
            {
                while (i < bank.ClientsList.Count)
                {
                    printClient.Client.Items.Add(manager.PrintClient(i));
                    i++;
                }
            }
            else while(i<bank.ClientsList.Count)
                {
                    printClient.Client.Items.Add(consultant.PrintClient(i));
                    i++;
                }
        }
        /// <summary>
        /// вызов окна редактирования коллекции клиентов в заввисимости от сотрудника по нажатию кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (flagManager)
            {
                editClientByManager = new EditClientByManager(manager);
                editClientByManager.Show();
            }
            else
            {
                editClientByConsultant = new EditClientByConsultant(consultant);
                editClientByConsultant.Show();
            }
        }
    }
}