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
using OnTapBaiKtraSo2.Models;

namespace OnTapBaiKtraSo2
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            QlspBkt2Context db = new QlspBkt2Context();
            var query = from sp in db.SanPhams
                        join lsp in db.LoaiSanPhams
                        on sp.MaLoai equals (lsp.MaLoai)
                        where lsp.MaLoai == "ML1"
                        select new
                        {
                            sp.MaSp,
                            sp.TenSp,
                            sp.MaLoai,
                            sp.SoLuong,
                            sp.DonGia,
                            ThanhTien = sp.SoLuong * sp.DonGia
                        };
            dvgTke.ItemsSource= query.ToList();

        }
    }
}
