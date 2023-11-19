using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Education.xaml
    /// </summary>
    public partial class Education : Page
    {
        public Education()
        {
            InitializeComponent();
        }

        private void Click_Next(object sender, RoutedEventArgs e)
        {


            if (!Classes.CheckRegex.Match(@"^\d{4} \d{8}$", serial.Text))
            {
                MessageBox.Show("Серия и номер документа об образовании не заполнены корректно");
                return;
            }

            if(!Classes.CheckRegex.Match(@"^\d{2}\.\d{2}$", bal.Text))
            {
                MessageBox.Show("Баллы не заполнены корректно");
                return;
            }

            if(!File.Exists(path.Text))
            {
                MessageBox.Show("Не удалось открыть файл");
                return;
            }
            FileInfo fileInfo = new FileInfo(path.Text);
            if(fileInfo.Length > 5 * 1024 * 1024)
            {
                MessageBox.Show("Выбранный файл слишком большой. Пожалуйста, выберите файл размером не более 5 МБ.");
                return;
            }

            MainWindow.main.NextPage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|PDF Files (*.pdf)|*.pdf";
            bool? result = dlg.ShowDialog();
            if (result == true)
                path.Text = dlg.FileName;         
        }
    }
}
