using OnTapBaiKtraSo2.Models;
using System;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace OnTapBaiKtraSo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Data Source=DESKTOP-UTIESKD\SQLEXPRESS;Initial Catalog=qlsp_bkt2;Integrated Security=True
        public MainWindow()
        {
            InitializeComponent();
        }
        QlspBkt2Context db = new QlspBkt2Context();

        public void HienThiDuLieuManHinh()
        {
            var query = from sp in db.SanPhams
                        orderby sp.DonGia ascending
                        select new
                        {
                            sp.MaSp,
                            sp.TenSp,
                            sp.MaLoai,
                            sp.SoLuong,
                            sp.DonGia,
                            ThanhTien = sp.SoLuong * sp.DonGia
                        };
            dvgData.ItemsSource = query.ToList();
        }
        public void HienThiCB()
        {
            var query = from lsp in db.LoaiSanPhams select lsp;
            //Xet du lieu cho combo box 
            cbLoai.ItemsSource = query.ToList().ToArray();
            cbLoai.DisplayMemberPath = "TenLoai";
            cbLoai.SelectedValuePath = "MaLoai";
            cbLoai.SelectedIndex = 0;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiDuLieuManHinh();
            HienThiCB();
        }

        private void btn_Them_Click(object sender, RoutedEventArgs e)
        {
            //Kiểm tra không cho nhập trùng mã sp
            string masp = txtMa.Text;
            var query = db.SanPhams.SingleOrDefault(s => s.MaSp.Equals(masp));
            if (query != null)
            {
                MessageBox.Show("Mã hàng " + masp + "đã tồn tại", "Thong bao");
                HienThiDuLieuManHinh();
            }
            else
            {
                //Tao mot san pham moi va loai san pham 
                SanPham sp = new SanPham();
                sp.MaSp = masp;
                sp.TenSp = txtTen.Text;
                sp.DonGia = double.Parse(txtDg.Text);
                sp.SoLuong = int.Parse(txtSl.Text);
                //Đến bước làm loại sản phẩm thì phải tách ra 
                LoaiSanPham itemSelected = (LoaiSanPham)cbLoai.SelectedItem;
                sp.MaLoai = itemSelected.MaLoai;

                //Them vao danh sach 
                db.SanPhams.Add(sp);
                db.SaveChanges();//Luu thay doi vao trong co so du lieu 
                MessageBox.Show("Thêm thành công", "Thông báo");
                HienThiDuLieuManHinh();

            }
        }
        //Cách chọn dòng trong data grid để dữ liệu hiển thị lên  , su dung su kien selected cell changed 

        private void btn_Sua_Click(object sender, RoutedEventArgs e)
        {
            //Kiểm tra không cho nhập trùng mã 

            var sp = db.SanPhams.SingleOrDefault(x => x.MaSp.Equals(txtMa.Text));
            if (sp == null)
            {
                MessageBox.Show("Mã hàng không tồn tại", "Thông báo");
                HienThiDuLieuManHinh();
            }
            else
            {
                sp.TenSp = txtTen.Text;
                sp.DonGia = float.Parse(txtDg.Text);
                sp.SoLuong = int.Parse(txtSl.Text);
                //Loai san pham 
                LoaiSanPham loaiSanPham = (LoaiSanPham)cbLoai.SelectedItem;
                sp.MaLoai = loaiSanPham.MaLoai;

                db.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo");
                HienThiDuLieuManHinh();

                //Sau khi hien thi lai du lieu tren man hinh 

            }

        }

        private void btn_Xoa_Click(object sender, RoutedEventArgs e)
        {
            var spXoa = db.SanPhams.SingleOrDefault(x => x.MaSp.Equals(txtMa.Text));
            if (spXoa == null)
            {
                MessageBox.Show("Không có sản phẩm này ");
            }
            else
            {
                MessageBoxResult mss = MessageBox.Show("Bạn có chắc chắn muốn xóa ", "Thông báo", MessageBoxButton.YesNo);
                if (mss == MessageBoxResult.Yes)
                {
                    db.SanPhams.Remove(spXoa);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công");
                    HienThiDuLieuManHinh();
                }
            }
        }

        private void btn_Tim_Click(object sender, RoutedEventArgs e)
        {
            LoaiSanPham lsp = (LoaiSanPham)cbLoai.SelectedItem;
            var query = from sp in db.SanPhams
                        where sp.MaLoai == lsp.MaLoai
                        select new
                        {
                            sp.MaSp,
                            sp.TenSp,
                            sp.MaLoai,
                            sp.SoLuong,
                            sp.DonGia,
                            ThanhTien = sp.SoLuong * sp.DonGia
                        };
            dvgData.ItemsSource = query.ToList();
        }

        private void dvgSp_selected_cell_changed(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dvgData.SelectedItem != null)//neu dòng trọn không phải là null 
            {
                try
                {
                    Type t = dvgData.SelectedItem.GetType();//Get type of data store in variables 
                    PropertyInfo[] p = t.GetProperties();//returns the attibutes associted with the property represend 
                    txtMa.Text = p[0].GetValue(dvgData.SelectedValue).ToString();
                    txtTen.Text = p[1].GetValue(dvgData.SelectedValue).ToString();
                    cbLoai.SelectedValue = p[2].GetValue(dvgData.SelectedValue).ToString();
                    txtSl.Text = p[3].GetValue(dvgData.SelectedValue).ToString();
                    txtDg.Text = p[4].GetValue(dvgData.SelectedValue).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi chọn hàng " + ex.Message, "Thông báo");
                }
            }
        }

    private void btn_TKe_Click(object sender, RoutedEventArgs e)
    {
        //Minh se viet chuc nang o MainWindow2 va goi vao main windown 1 
        Window2 window2 = new Window2();
        window2.Show();//Để hiển thị bảng ưindow2 mình sẽ có chức năng window2.Show();

    }
}
}
