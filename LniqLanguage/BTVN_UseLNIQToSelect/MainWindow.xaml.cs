using BTVN_UseLNIQToSelect.Models;
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
using System.Windows.Media.Media3D.Converters;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BTVN_UseLNIQToSelect
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
        QuanlyluongContext qll = new QuanlyluongContext();

        public void ShowDataEmployee()
        {
            //Câu 1 : Hiển thị dữ liệu bảng nhân viên 
            //C1 
            var listNvC1 = from list in qll.Nhanviens
                           select list;
            //C2 
            var listNvC2 = qll.Nhanviens.Select(x => x);

        }

        public void SelectOptions()
        {
            //Câu 2 : Đưa ra các thông tin sau : Mnv ,Họ tên , Ngày sinh , hệ số lương 
            //C1
            var listOption = from list in qll.Nhanviens
                             select new { list.Manv, list.Hoten, list.Ngaysinh, list.Hesoluong };
            //C2 
            var listOption2 = qll.Nhanviens.Select(item => new { item.Manv, item.Hoten, item.Ngaysinh, item.Hesoluong });
        }


        public void SelectTop3Employee()
        {
            //Câu 3 : Đưa ra 3 nhân viên có hệ số lương cao nhất gồm MNV , Họ tên , Ngày sinh , Hệ số lương 
            //C1
            var listEmp = (from list in qll.Nhanviens
                           orderby list.Hesoluong ascending
                           select new { list.Manv, list.Hoten, list.Ngaysinh, list.Hesoluong })
                           .Take(3).ToList();

            //C2 
            var listEmp2 = qll.Nhanviens.OrderByDescending(item => item.Hesoluong).Take(3).ToList();
        }
        public void SelectDataFromTwoTable()
        {
            //Câu 4 : Đưa ra các thông tin sau : Manv , họ tên , Ngày sinh , Giới tính , Tên Dv 
            //C1 
            var data = from nv in qll.Nhanviens
                       join dv in qll.Donvis
                       on nv.Madv equals dv.Madv
                       select new { nv.Manv, nv.Hoten, nv.Ngaysinh, nv.Gioitinh, dv.Tendv };

            //C2 
            var data2 = qll.Nhanviens.Join(qll.Donvis, p => p.Madv, k => k.Madv,
                (p, k) => new { p.Manv, p.Hoten, p.Ngaysinh, p.Gioitinh, k.Tendv })
                .Select(p => p.Manv).ToList();
        }

        public void SelectDataFromTwoTable2()
        {
            //Câu 5 : Đưa ra các thông tin sau : Manv , Họ tên , Ngày sinh , Hsluong , phụ cấp , tên DV 
            //C1 
            var list = from dv in qll.Donvis
                       join nv in qll.Nhanviens
                       on dv.Madv equals nv.Madv
                       join cv in qll.Chucvus
                       on nv.Macv equals cv.Macv
                       select new { nv.Manv, nv.Hoten, nv.Ngaysinh, nv.Hesoluong, cv.Phucap, dv.Tendv };

            //C2 
            var list2 = qll.Chucvus.Join(qll.Nhanviens, cv => cv.Macv, nv => nv.Macv, (cv, nv) => new { cv.Phucap, nv })
                            .Join(qll.Donvis, dv => dv.nv.Madv, ep => ep.Madv, (dv, ep) => new
                            {
                                dv.nv.Manv,
                                dv.nv.Hoten,
                                dv.nv.Ngaysinh,
                                dv.nv.Hesoluong
                            });
        }
        //Câu 6 : Đưa ra các thông tin : Manv , Họ tên , ngày sinh , hệ số lương 
        //Luong(=Hsl * 830000 + Phụ cấp ) 
        public void SelectDataFromTwoTable3()
        {
            var list3 = from nv in qll.Nhanviens
                        join dv in qll.Donvis
                        on nv.Madv equals dv.Tendv
                        join cv in qll.Chucvus
                        on nv.Macv equals cv.Macv
                        select new { nv.Manv, nv.Hoten, nv.Ngaysinh, nv.Hesoluong, Luong = (nv.Hesoluong * 830000 + cv.Phucap) };

        }

        //Câu 7 : Đưa ra các nhân viên có trình độ "Đại học" được xếp giảm dần theo Hệ số lương
        //gồm các thông tin : Manv , Họ tên , Giới tính , HSLuong , Trinh đo , Ten dv 
        public void SelectDataFromTwoTable4()
        {
            var list = from nv in qll.Nhanviens
                       join dv in qll.Donvis
                       on nv.Madv equals dv.Madv
                       where nv.Trinhdo == "Đại học"
                       orderby nv.Hesoluong descending
                       select new { nv.Manv, nv.Hoten, nv.Gioitinh, nv.Hesoluong, nv.Trinhdo, dv.Tendv };
        }

        //Câu 8 : Thống kê số nv trong từng đơn vị với các thông tin : Mã dv , tên dv , số người 

        public void SelectDataFromTwoTable5()
        {
            var query1 = from nv in qll.Nhanviens
                         join dv in qll.Donvis
                         on nv.Madv equals dv.Madv
                         group nv by new
                         {
                             dv.Madv,
                             dv.Tendv

                         } into GlbDv
                         select new
                         {
                             MaDv = GlbDv.Key.Madv,
                             TenDvi = GlbDv.Key.Tendv,
                             SoNhanVien = GlbDv.Count()
                         };
              DvgData.ItemsSource = query1.ToList();


        }
        //Câu 9 : Thống kê tổng lương trong từng đơn vị với các thông tin sau : Mã dv , tên dv , tổng lương 
        //nếu muốn thực hành thao tác trên mỗi nhóm , ta sử dụng từ khóa into để tạo định danh cho nhóm này có kiểu IGrouping <Tkey , TElement>
        //vì vậy ta có thể dùng property key để lấy giá trị của nhóm 
        //Sử dụng subquery để truy vấn dữ liệu trên mỗi nhóm 
        public void SelectSumOfMoney()
        {
            var query1 = from nv in qll.Nhanviens
                         join dv in qll.Donvis
                         on nv.Madv equals dv.Madv
                         join cv in qll.Chucvus
                         on nv.Macv equals cv.Macv
                         group dv by new
                         {
                             dv.Madv,
                             dv.Tendv,
                             //nv.Hesoluong,
                             //cv.Phucap
                         }
                         into TkeTongTien
                         select new
                         {
                             MaDonVi = TkeTongTien.Key.Madv,
                             Tendv = (TkeTongTien.Key.Tendv),
                             TongTien = 123
                             //TongTien = TkeTongTien.Sum(X => TkeTongTien.Key.Hesoluong * 830000 + TkeTongTien.Key.Phucap)
                         };

         DvgData.ItemsSource = query1.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SelectSumOfMoney();
            //SelectDataFromTwoTable5();
        }
    }
}
