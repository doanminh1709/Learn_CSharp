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
using System.Windows.Shapes;
using OnTapKtrB2_So2.Models;

namespace OnTapKtrB2_So2
{
    /// <summary>
    /// Interaction logic for Windown2.xaml
    /// </summary>
    public partial class Windown2 : Window
    {
        public Windown2()
        {
            InitializeComponent();
        }
        quanlysinhvienContext qlsv = new quanlysinhvienContext();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from khoa in qlsv.Khoas join sv in qlsv.SinhViens
                        on khoa.Makhoa equals sv.Makhoa
                        group khoa by new
                        {
                            khoa.Makhoa,
                            khoa.Tenkhoa,
                        } into k
                        select new
                        {
                            MaKhoa = k.Key.Makhoa,
                            TenKhoa = k.Key.Tenkhoa,
                            SoNguoi = k.Count()
         };

            dvgKhoa.ItemsSource = query.ToList();
     }
 }
}
