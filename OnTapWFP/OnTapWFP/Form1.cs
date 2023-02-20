using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapWFP
{
    public partial class Form1 : Form
    {
        List<SinhVien> listSv;
        public Form1()
        {
            InitializeComponent();
            listSv = new List<SinhVien>();
        }
        public bool checkControl()
        {

            if (string.IsNullOrWhiteSpace(txtTenSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Con trỏ cần phải trỏ đến mục mà người dùng chưa nhập ta có hàm Focus()
                txtTenSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMsv.Text))
            {
                MessageBox.Show("Bạn chưa nhập masv", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMsv.Focus();
                return false;
            }
    
            if (string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiem.Focus();
                return false;
            }

            return true;
        }


        private void add_Click(object sender, EventArgs e)
        {
            if (checkControl())
            {
                
                string masv = txtMsv.Text;
                string tensv = txtTenSV.Text;
                float diem = Convert.ToSingle(txtDiem.Text);
                SinhVien sv = new SinhVien(masv , tensv , diem);

                //Check sv trung ma 
                SinhVien t = new SinhVien(masv);
                int index = listSv.IndexOf(t);//Không tìm thấy trả về -1 , ngược lại trả về index
                if (index == -1)
                {
                    listSv.Add(sv);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listSv;
                    dataGridView1.Refresh();   
                }
                else
                {
                    MessageBox.Show("Sinh viên không được trùng mã nhau", "Cảnh cáo",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        int index;//Vị trí thì sẽ khai báo biến toàn cục 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridViewCellEventArgs : có tác dụng lắng nghe sự kiện 
            index = e.RowIndex;
            if (index >= 0)
            {
                txtMsv.Text = listSv[index].MaSv.ToString();
                txtTenSV.Text = listSv[index].TenSv.ToString();
                txtDiem.Text = listSv[index].Diem.ToString();

            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                listSv[index].MaSv = txtMsv.Text;
                listSv[index].TenSv = txtTenSV.Text;
                listSv[index].Diem = float.Parse(txtDiem.Text);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listSv;
                MessageBox.Show("SỬA THÔNG TIN SINH VIÊN THÀNH CÔNG");
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                //Hiển thị MesageBox và lắng nghe người dùng kích Ok hay Cancel 
                if (MessageBox.Show(" Bạn có muốn xóa sinh viên này ?", "Cảnh cáo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    listSv.RemoveAt(index);
                    //Sau khi xóa ở trong list mình phải gán lại dataGridView để nó hiển thị lại dữ liệu 
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listSv;
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listSv.Sort((e1, e2) =>
            {
                return e1.TenSv.CompareTo(e2.TenSv);
            });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listSv;
            MessageBox.Show("Săp xếp tăng dần theo tên thành công");
        }

        //tìm kiếm theo mã sinh viên hoặc tên sinh viên 
        private void btnSearch_Click(object sender, EventArgs e)
        {
         
            string key = txtBoxSearch.Text.Trim();
            //Duyệt qua tất cả các bản ghi 
            //Để tìm kiếm trên list ta phải tìm kiếm trên dataGridView 
            if (!string.IsNullOrWhiteSpace(key))
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listSv;
                List<SinhVien> svs = new List<SinhVien>();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString().ToUpper().Contains(key.ToUpper()))
                        svs.Add(listSv[i]);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = svs;

            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listSv;
            }
        }


        //Sự kiện textChange , sẽ thay đổi khi ta gõ vào textBox
        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string key = txtBoxSearch.Text.Trim();
            //Duyệt qua tất cả các bản ghi 
            //Để tìm kiếm trên list ta phải tìm kiếm trên dataGridView 
            if (!string.IsNullOrWhiteSpace(key))
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listSv;
                List<SinhVien> svs = new List<SinhVien>();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString().ToUpper().Contains(key.ToUpper()))
                        svs.Add(listSv[i]);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = svs;
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listSv;
            }
        }
        
    }
}


