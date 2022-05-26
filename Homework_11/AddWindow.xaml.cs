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
using System.Windows.Shapes;

namespace Homework_11
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        Manager manager;
        public AddWindow(Manager Manager)
        {
            InitializeComponent();
            manager = Manager;
        }
        /// <summary>
        /// Метод добавления записи менеджером банка в коллекцию клиентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOKButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string firstname = FirstNameBox.Text;
                string middlename = MiddleNameBox.Text;
                string lastname = LastNameBox.Text;
                long telephone = Convert.ToInt64(TelephoneBox.Text);
                string serial = SerialBox.Text;
                manager.AddClient(new Client(firstname, middlename, lastname, telephone, serial));
                this.Close();
            }
            catch (Exception)
            {
                return;
            }
            
        }
    }
}
