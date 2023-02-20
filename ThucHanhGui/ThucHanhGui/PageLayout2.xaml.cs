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

namespace ThucHanhGui
{
    /// <summary>
    /// Interaction logic for PageLayout2.xaml
    /// </summary>
    public partial class PageLayout2 : Window
    {
        List<SinhVien> listSv;
        public PageLayout2()
        {
            InitializeComponent();
            listSv = new List<SinhVien>();

        }

      public bool checkControl()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                //Con trỏ cần phải trỏ đến mục mà người dùng chưa nhập ta có hàm Focus()
                txtHoTen.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMsv.Text))
            {
                MessageBox.Show("Bạn chưa nhập masv", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMsv.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtQueQuan.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên lớp", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtQueQuan.Focus();
                return false;
            }

            return true;
        }


        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            if (checkControl()) {
                SinhVien sv = new SinhVien(txtHoTen.Text , txtMsv.Text , txtQueQuan.Text);
                listSv.Add(sv);
                
                
            }
        }

        private void Button_Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Remove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Soft_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    class SinhVien
    {
        private String masv;

        private String tensv;

        private String quequan;

        public String MaSv
        {
            get { return masv; }
            set { masv = value; }
        }
        public String TenSv
        {
            get { return tensv; }
            set { tensv = value; }
        }
        public String QueQuan
        {
            get { return quequan; }
            set { quequan = value; }
        }
        public SinhVien()
        {
            masv = "";
            tensv = "";
            quequan = "";
        }
        public SinhVien(String masv , String tensv , String quequan)
        {
            this.masv= masv;
            this.tensv= tensv;
            this.quequan  = quequan;
        }

    }
}
