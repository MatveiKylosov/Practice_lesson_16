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

namespace Submission_of_Applications_Kylosov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Page> pages = new List<Page>();
        int i = 0;
        public static MainWindow main;
        public MainWindow()
        {
            InitializeComponent();
            main = this;
            pages.Add(new Pages.Statement());
            pages.Add(new Pages.Education());
            pages.Add(new Pages.Status());
            pages.Add(new Pages.Speciality());
            pages.Add(new Pages.Passport());
            pages.Add(new Pages.Contacts());
            pages.Add(new Pages.Parents());

            NextPage();
        }

        public void NextPage()
        {
            i = i == pages.Count ? 0 : i;
            frame.Navigate(pages[i++]);
        }
    }
}
