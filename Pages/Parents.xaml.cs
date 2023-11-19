using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
    /// Логика взаимодействия для Parents.xaml
    /// </summary>
    public partial class Parents : Page
    {
        public Parents()
        {
            InitializeComponent();
        }

        private void Click_Next(object sender, RoutedEventArgs e)
        {
            if(tb1.Text != "")
            {
                if(!Classes.CheckRegex.Match(@"^[а-яА-Я]+ [а-яА-Я]+ [а-яА-Я]+$", tb1.Text))
                {
                    MessageBox.Show("Заполните корректно ФИО законного представителя");
                    return;
                }
                
                if (!Classes.CheckRegex.Match(@"^(0[1-9]|[12][0-9]|3[01]).(0[1-9]|1[012]).(19|20)\d\d$", tb2.Text))
                {
                    MessageBox.Show("Заполните корректно дату рождения законного представителя");
                    return;
                }
                if (tb3.Text == "")
                {
                    MessageBox.Show("Заполните место работы");
                    return;
                }

                if (tb4.Text == "")
                {
                    MessageBox.Show("Заполните должность");
                    return;
                }

                if (tb5.Text == "")
                {
                    MessageBox.Show("Заполните место жительство");
                    return;
                }

                if (tb6.Text != "" & !Classes.CheckRegex.Match(@"\d{3}-\d{2}-\d{2}$", tb6.Text))
                {
                    MessageBox.Show("Заполните корректно домашний телефон");
                    return;
                }

                if (!Classes.CheckRegex.Match(@"^\+7-\d{3}-\d{3}-\d{2}-\d{2}$", tb7.Text))
                {
                    MessageBox.Show("Номер телефон заполнен не корректно");
                    return;
                }

                if (!(bool)cb1.IsChecked)
                {
                    MessageBox.Show("Поставьте галочку.");
                    return;
                }
            }

            if (tb8.Text != "" & (bool)cb1.IsChecked)
            {
                if (!Classes.CheckRegex.Match(@"^[а-яА-Я]+ [а-яА-Я]+ [а-яА-Я]+$", tb8.Text))
                {
                    MessageBox.Show("Заполните корректно ФИО законного представителя");
                    return;
                }

                if (!Classes.CheckRegex.Match(@"^(0[1-9]|[12][0-9]|3[01]).(0[1-9]|1[012]).(19|20)\d\d$", tb9.Text))
                {
                    MessageBox.Show("Заполните корректно дату рождения законного представителя");
                    return;
                }
                if (tb10.Text == "")
                {
                    MessageBox.Show("Заполните место работы");
                    return;
                }

                if (tb11.Text == "")
                {
                    MessageBox.Show("Заполните должность");
                    return;
                }

                if (tb12.Text == "")
                {
                    MessageBox.Show("Заполните место жительство");
                    return;
                }

                if (tb13.Text != "" & !Classes.CheckRegex.Match(@"\d{3}-\d{2}-\d{2}$", tb13.Text))
                {
                    MessageBox.Show("Заполните корректно домашний телефон");
                    return;
                }

                if (!Classes.CheckRegex.Match(@"^\+7-\d{3}-\d{3}-\d{2}-\d{2}$", tb14.Text))
                {
                    MessageBox.Show("Номер телефон заполнен не корректно");
                    return;
                }
                if (!(bool)cb2.IsChecked)
                {
                    MessageBox.Show("Поставьте галочку.");
                    return;
                }
            }

            MainWindow.main.NextPage();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
