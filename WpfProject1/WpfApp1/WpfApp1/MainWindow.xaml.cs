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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String strMessage, strHoten, strTitle = " ", strNgoaiNgu = "";
            strHoten = txtHoDem.Text + " " + txtTen.Text;
            if (radioNam.IsChecked == true)
            {
                strTitle = "Mr.";
            }
            if (radioNu.IsChecked == true)
            {
                strTitle = "Miss.";
            }
            strMessage = "Xin chào " + strTitle + " " + strHoten;
            if (CbTA.IsChecked == true)
            {
                strNgoaiNgu = "Tiếng Anh";
            }
            if (CbTT.IsChecked == true)
            {
                _ = CbTA.IsChecked != false ? strNgoaiNgu = "Tiếng Trung và Tiếng Anh" : strNgoaiNgu = "Tiếng Trung";
            }
            strMessage += "\nNgoại ngữ : " + strNgoaiNgu;
            String strQq = CbQq.Text;
            if (CbQq.SelectedIndex >= 0)
            {
                strMessage += "\nQuê quán : " + CbQq.Text;
            }
            MessageBox.Show(strMessage);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtHoDem.Text = "";
            txtTen.Text = "";
            radioNam.IsChecked = true;
            radioNu.IsChecked = true;
            CbTA.IsChecked = false;
            CbTT.IsChecked = false;
            CbQq.SelectedIndex = 0;

        }
    }
}
