using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для Passport.xaml
    /// </summary>
    public partial class Passport : Page
    {
        public Passport()
        {
            InitializeComponent();
        }

        private void Click_Next(object sender, RoutedEventArgs e)
        {
            if (!Classes.CheckRegex.Match(@"^[а-яА-Я ]+$", tb1.Text))
            {
                MessageBox.Show("Фамилия указана некорректно");
                return;
            }

            if (!Classes.CheckRegex.Match(@"^[а-яА-Я ]+$", tb2.Text))
            {
                MessageBox.Show("Имя указано некорректно"); return;
            }
            if (!Classes.CheckRegex.Match(@"^[а-яА-Я ]+$", tb3.Text))
            {
                MessageBox.Show("Отчество указано некорректно"); return;
            }
            if (!Classes.CheckRegex.Match(@"^(0[1-9]|[12][0-9]|3[01]).(0[1-9]|1[012]).(19|20)\d\d$", tb4.Text))
            {
                MessageBox.Show("Дата рождения указана некорректно"); return;
            }
            if (!Classes.CheckRegex.Match(@"^[а-яА-Я ]+$", tb5.Text))
            {
                MessageBox.Show("Гражданство указано некорректно"); return;
            }
            if (!Classes.CheckRegex.Match(@"^[а-яА-Я ]+$", tb6.Text))
            {
                MessageBox.Show("Место рождение указано не корректно"); return;
            }
            if (!Classes.CheckRegex.Match(@"^\d{4} \d{2} \d{6}$", tb7.Text))
            {
                MessageBox.Show("Серия и номер паспорта указаны не корректно"); return;
            }
            if (!Classes.CheckRegex.Match(@"^(0[1-9]|[12][0-9]|3[01]).(0[1-9]|1[012]).(19|20)\d\d$", tb8.Text))
            {
                MessageBox.Show("Дата выдачи указана некорректно"); return;
            }
            if (!Classes.CheckRegex.Match(@"^\d{3}-\d{3}", tb9.Text))
            {
                MessageBox.Show("Код подразделения указан не правильно"); return;
            }

            if (tb10.Text == "")
            {
                MessageBox.Show("Укажите кем выдан паспорт"); return;
            }
            if (tb11.Text == "")
            {
                MessageBox.Show("Укажите адрес"); return;
            }
            if (tb12.Text == "")
            {
                MessageBox.Show("Укажите район"); return;
            }
            if (tb13.Text == "")
            {
                MessageBox.Show("Укажите фактический адрес"); return;
            }
            if (tb14.Text == "")
            {
                MessageBox.Show("Укажите фактический район"); return;
            }


            string[] arr = tb15.Text.Split('|');
            if (tb15.Text == "" || arr.Length <= 0)
            {
                MessageBox.Show("Не указаны файлы.");
                return;
            }
            foreach (string filePath in arr)
            {
                if (File.Exists(filePath))
                {
                    FileInfo fileInfo = new FileInfo(filePath);
                    // Проверка размера файла (5 МБ в байтах)
                    if (fileInfo.Length > 5 * 1024 * 1024)
                    {
                        MessageBox.Show("Выбранный файл слишком большой. Пожалуйста, выберите файл размером не более 5 МБ.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Файл " + filePath + " не найден. Пожалуйста, выберите существующий файл.");
                    return;
                }
            }
            MainWindow.main.NextPage();
        }

        private void tb14_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|PDF Files (*.pdf)|*.pdf";
            bool? result = dlg.ShowDialog();
            if (result == true)
                tb15.Text = dlg.FileName;
        }
    }
}
