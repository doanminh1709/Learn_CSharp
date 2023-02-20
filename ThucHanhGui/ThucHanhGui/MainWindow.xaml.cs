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

namespace ThucHanhGui
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click_NhapSv(object sender, RoutedEventArgs e)
        {
            PageLayout2 l2 = new PageLayout2();
            l2.Show();

        }


        private void MenuItem_Click_Sp(object sender, RoutedEventArgs e)
        {

        }

        private void Click_NhapKhoa(object sender, RoutedEventArgs e)
        {
            new PageLayoutKhoa().Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
