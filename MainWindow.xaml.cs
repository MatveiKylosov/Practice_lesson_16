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
            pages = new List<Page>
                                {
                                    new Pages.Statement(),
                                    new Pages.Education(),
                                    new Pages.Status(),
                                    new Pages.Speciality(),
                                    new Pages.Passport(),
                                    new Pages.Contacts(),
                                    new Pages.Parents()
                                };
            NextPage();
        }


        public void NextPage()
        {
            frame.Navigate(pages[i]);
            i = (i + 1) % pages.Count;
        }

    }
}
