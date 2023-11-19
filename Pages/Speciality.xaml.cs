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
    /// Логика взаимодействия для Speciality.xaml
    /// </summary>
    public partial class Speciality : Page
    {
        public Speciality()
        {
            InitializeComponent();
        }

        private void Click_Next(object sender, RoutedEventArgs e)
        {
            if (!(bool)cb1.IsChecked &
                !(bool)cb2.IsChecked &
                !(bool)cb3.IsChecked &
                !(bool)cb4.IsChecked &
                !(bool)cb5.IsChecked &
                !(bool)cb6.IsChecked &
                !(bool)cb7.IsChecked &
                !(bool)cb8.IsChecked &
                !(bool)cb9.IsChecked &
                !(bool)cb10.IsChecked &
                !(bool)cb11.IsChecked &
                !(bool)cb12.IsChecked &
                !(bool)cb13.IsChecked )
            {
                MessageBox.Show("Необходимо выбрать хоть одно направление");
                return;
            }

            if (!(bool)cb14.IsChecked && !(bool)cb15.IsChecked)
            {
                MessageBox.Show("Обязательный для соглашения");
                return;
            }
            MainWindow.main.NextPage();
        }
    }
}
