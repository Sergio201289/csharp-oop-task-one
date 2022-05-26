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
    /// Логика взаимодействия для EditClientByManager.xaml
    /// </summary>
    public partial class EditClientByManager : Window
    {
        Manager manager;
        public EditClientByManager(Manager Manager)
        {
            InitializeComponent();
            manager = Manager;
        }
        /// <summary>
        /// Изменение одного из полей записи о клиенте менеджером банка по нажатию кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)FirstName.IsChecked) manager.ChangeFirstName(Convert.ToInt32(Index.Text)-1, Value.Text);
                else if ((bool)MiddleName.IsChecked) manager.ChangeMiddleName(Convert.ToInt32(Index.Text)-1, Value.Text);
                else if ((bool)LastName.IsChecked) manager.ChangeLastName(Convert.ToInt32(Index.Text)-1, Value.Text);
                else if ((bool)TelephoneNumber.IsChecked) manager.ChangeTelephoneNumber(Convert.ToInt32(Index.Text)-1, Value.Text);
                else manager.ChangeSerialOfDocument(Convert.ToInt32(Index.Text)-1, Value.Text);
                this.Close();
            }
            catch
            {
                return;
            }
        }
    }
}
