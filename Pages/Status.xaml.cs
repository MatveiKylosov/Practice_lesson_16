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
    /// Логика взаимодействия для Status.xaml
    /// </summary>
    public partial class Status : Page
    {
        public Status()
        {
            InitializeComponent();
        }

        private void Click_Next(object sender, RoutedEventArgs e)
        {
            if ((bool)rb1.IsChecked)
            {
                string[] arr = path.Text.Split('|');
                if (path.Text == "" || arr.Length <= 0)
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
            }
            MainWindow.main.NextPage();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|PDF Files (*.pdf)|*.pdf";
            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                // Объединение всех путей в одну строку, разделенную запятыми
                string allPaths = string.Join("|", dlg.FileNames);
                path.Text = allPaths;
            }

        }
    }
}
