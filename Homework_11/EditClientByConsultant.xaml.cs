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
    /// Логика взаимодействия для EditClientByConsultant.xaml
    /// </summary>
    public partial class EditClientByConsultant : Window
    {
        Consultant consultant;
        public EditClientByConsultant(Consultant Consultant)
        {
            InitializeComponent();
            consultant = Consultant;
        }
        /// <summary>
        /// Изменение телефонного номера консультантом банка по нажатию кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                consultant.ChangeTelephoneNumber(Convert.ToInt32(Index.Text)-1, Value.Text);
                this.Close();
            }
            catch
            {
                return;
            }
        }
    }
}
