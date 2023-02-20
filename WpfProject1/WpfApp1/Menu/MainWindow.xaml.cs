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

namespace Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem211_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn chọn Menu 211");
        }

        private void MenuItem212_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn chọn Menu 212");
        }

        private void MenuItem_Click_22(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn chọn Menu 22");
        }

        private void Menu3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn chọn Menu 3");
        }

        private void IncreaseFont_Click(object sender, RoutedEventArgs e)
        {
            if(txtBox1.FontSize < 30)
            {
                txtBox1.FontSize += 2;
            }

        }

        private void DecreaseFont_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox1.FontSize > 10)
            {
                txtBox1.FontSize -= 2;
            }
        }

        private void Bold_Checked(object sender, RoutedEventArgs e)
        {
            txtBox1.FontWeight = FontWeights.Bold;
        }

        private void Bold_Unchecked(object sender, RoutedEventArgs e)
        {
            txtBox1.FontWeight = FontWeights.Normal;
        }

        private void Italic_Checked(object sender, RoutedEventArgs e)
        {
            txtBox1.FontStyle = FontStyles.Italic;
        }

        private void Italic_Unchecked(object sender, RoutedEventArgs e)
        {
            txtBox1.FontStyle = FontStyles.Normal;
        }
    }
}
