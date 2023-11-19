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
    /// Логика взаимодействия для Statement.xaml
    /// </summary>
    public partial class Statement : Page
    {
        public Statement()
        {
            InitializeComponent();
        }

        private void Click_Next(object sender, RoutedEventArgs e)
        {
            if(!Classes.CheckRegex.Match(@"^[а-яА-Я ,]+$", tb1.Text))
            {
                MessageBox.Show("Не заполнена информация об окончании образовательного учереждении");
                return;
            }

            if (!Classes.CheckRegex.Match(@"^\d{4}$", tb2.Text))
            {
                MessageBox.Show("Не заполнена информация об годе окончании образовательного учереждении");
                return;
            }
            MainWindow.main.NextPage();
        }
    }
}
