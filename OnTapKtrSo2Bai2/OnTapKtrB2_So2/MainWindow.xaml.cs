using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.RightsManagement;
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
using Microsoft.Data.SqlClient.DataClassification;
using OnTapKtrB2_So2.Models;

namespace OnTapKtrB2_So2
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

        quanlysinhvienContext db = new quanlysinhvienContext();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiDuLieu();
            ShowCbBox();
        }

        public void HienThiDuLieu()
        {
            var query = db.SinhViens.OrderBy(x => x.Tensv).Select(x => new
            {
                x.Masv,
                x.Tensv,
                x.Quequan,
                x.Makhoa,
                x.DiemTk
            });
            dvgSv.ItemsSource = query.ToList();
        }

        public bool CheckDataInputIsValid()
        {
            //Kiem tra xem nguoi dung da nhap day du du lieu hay chua 
            string message = "";
            if (txtMsv.Text == "" || txtTensv.Text == "" || txtQq.Text == "" || txtDtk.Text == "")
            {
                message += "\nNhập đầy đủ dữ liệu";
            }
            //Check dau vao ma masv

            if (!Regex.IsMatch(txtMsv.Text, @"^[\w\S]+$"))
            {
                message += "\nNhập đúng định dạng mã sinh viên";
            }

            //Check dau vao ten sinh vien 
            if (!Regex.IsMatch(txtTensv.Text, @"^[a-zA-Z\s]+$"))
            {
                message += "\nNhập đúng định dạng tên sinh viên";
            }
            if (!Regex.IsMatch(txtQq.Text, @"^[a-zA-Z0-9\s]{6,}$"))
            {
                message += "\nNhập đúng định dạng quê quán";
            }
            if (!Regex.IsMatch(txtDtk.Text, @"\d+"))
            {
                message += "\nNhập điểm tổng kết là số";
            }
            else
            {
                float dtk = float.Parse(txtDtk.Text);
                if (dtk < 0 || dtk > 10)
                {
                    message += "\nĐiểm tổng kết không thỏa mãn. Nhập lại!";
                }
            }
            if (message != "")
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }


        public void ShowCbBox()
        {
            //Select ra khoa 
            var query = db.Khoas.Select(x => x);
            cbKhoa.ItemsSource = query.ToList();

            //Hien thi ra gia tri la ten khoa
            cbKhoa.DisplayMemberPath = "Tenkhoa";//LUU Y PHAI GHI DUNG SO VOI DU LIEU O TRONG DATABASE 

            //Nhung khi chon vao thi luu vao co so du lieu la ma thuoc tinh maKhoa
            cbKhoa.SelectedValuePath = "Makhoa";

            cbKhoa.SelectedIndex = 0;
        }

        private void btn_Click_Sua(object sender, RoutedEventArgs e)
        {
            var sv = db.SinhViens.SingleOrDefault(x => x.Masv.Equals(txtMsv.Text.Trim()));
            if (sv != null)
            {
                sv.Tensv = txtTensv.Text;
                sv.Quequan = txtQq.Text;
                Khoa slt = (Khoa)cbKhoa.SelectedItem;
                sv.Makhoa = slt.Makhoa;
                sv.DiemTk = float.Parse(txtDtk.Text);
                db.SaveChanges();
                HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("Mã sinh viên không tồn tại", "Thông báo");
                HienThiDuLieu();
            }
        }

        private void btn_Click_Xoa(object sender, RoutedEventArgs e)
        {
            var sv = db.SinhViens.SingleOrDefault(x => x.Masv.Equals(txtMsv.Text));
            if (sv != null)
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sv này ?"
                    , "Thông báo", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    db.SinhViens.Remove(sv);
                    db.SaveChanges();
                    HienThiDuLieu();
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại mã sinh viên", "Thông báo");
                HienThiDuLieu();
            }
        }

        private void btn_Click_Tim(object sender, RoutedEventArgs e)
        {
            Khoa khoa = (Khoa)cbKhoa.SelectedItem;
            var query = db.SinhViens.Where(x => x.Makhoa == khoa.Makhoa).Select(x => x);
            dvgSv.ItemsSource = query.ToList();
        }

        private void btn_Click_Tk(object sender, RoutedEventArgs e)
        {
            Windown2 wd2 = new Windown2();
            wd2.Show();
        }

        private void btn_Click_Them(object sender, RoutedEventArgs e)
        {
            var query = db.SinhViens.SingleOrDefault(x => x.Masv.Equals(txtMsv.Text));
            if (query != null)
            {
                MessageBox.Show("Mã sinh viên này đã tồn tại", "Thông báo");
                HienThiDuLieu();
            }
            else
            {
                try
                {
                    if (CheckDataInputIsValid())
                    {
                        SinhVien svm = new SinhVien();
                        svm.Masv = txtMsv.Text;
                        svm.Tensv = txtTensv.Text;
                        svm.Quequan = txtQq.Text;
                        //De add khoa vao thi ta phai chon vao ten khoa dang chon va tu do lay ra ma khoa 
                        Khoa khoa = (Khoa)cbKhoa.SelectedItem;//Sau khi da chon ra duoc roi thi minh chi viec lay ra du lieu cua khoa 
                        svm.Makhoa = khoa.Makhoa;
                        db.SinhViens.Add(svm);
                        //Sau khi them thi save lai database 
                        db.SaveChanges();
                        HienThiDuLieu();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi nhập " + ex, "Thông báo");
                }
           }
        }

        private void dvgSv_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dvgSv.SelectedItem != null)
            {
                try
                {
                    Type t = dvgSv.SelectedItem.GetType();
                    PropertyInfo[] pr = t.GetProperties();//property attribute socciabted 

                    //get ra gia tri get value 
                    txtMsv.Text = pr[0].GetValue(dvgSv.SelectedValue).ToString();

                    txtTensv.Text = pr[1].GetValue(dvgSv.SelectedValue).ToString();

                    txtQq.Text = pr[2].GetValue(dvgSv.SelectedValue).ToString();

                    cbKhoa.SelectedValue = pr[3].GetValue(dvgSv.SelectedValue).ToString();//Muốn hiển thị ra dữ liệu trên cb box ta phải hiển thị ra tt selected value của nó 

                    txtDtk.Text = pr[4].GetValue(dvgSv.SelectedValue).ToString();
                }catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra " + ex, "Thông báo");
                }
            }
        }

        //Viet code hien thi du lieu len O box khi kich vao cell data grid 
    }
}
