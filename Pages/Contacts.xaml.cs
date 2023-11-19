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

namespace Submission_of_Applications_Kylosov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Contacts.xaml
    /// </summary>
    public partial class Contacts : Page
    {
        public Contacts()
        {
            InitializeComponent();
        }
        private void Click_Next(object sender, RoutedEventArgs e)
        {
            if (NumberHome.Text != "" & !Classes.CheckRegex.Match(@"\d{3}-\d{2}-\d{2}$", NumberHome.Text))
            {
                MessageBox.Show("Домашний телефон заполнен не корректно");
                return;
            }
            if(!Classes.CheckRegex.Match(@"^\+7-\d{3}-\d{3}-\d{2}-\d{2}$", Phone.Text))
            {
                MessageBox.Show("Номер телефон заполнен не корректно");
                return;
            }
            if (!Classes.CheckRegex.Match(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", Email.Text))
            {
                MessageBox.Show("Почта заполнена не корректно");
                return;
            }
            MainWindow.main.NextPage();
        }
    }
}
