using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    //Để so sánh tiêu chí sắp xếp sinh viên ta có 2 cách 1 implement method IComperable , cách 2 là Implement method comperator 
    internal class SinhVien : Person , IComparable
    {
        private string masv;
        private double diem { get; set; }
        private String xeploai
        {
            get {
                if (diem > 0 && diem < 5)
                {
                    return "Kem";
                }
                else if (diem < 6.5)
                {
                    return "Trung binh";
                }
                else if (diem < 8)
                {
                    return "Kha";
                }
                else if (diem <= 10)
                {
                    return "Gioi";
                }
                else
                {
                    return "";
                }
            }
            set { masv = value; }

        }


        public string MaSv
        {
            get { return masv; }
            set { masv = value; }
        }

        public double DiemSv
        {
            get { return diem; }
            set { diem = value; }
            
        }
        public SinhVien(string msv)
        {
            this.masv = msv;
        }
        public SinhVien() : base()
        {
            masv = "";
            diem = 0.0;
            xeploai = "";
        }

        public SinhVien(string masv, double diem, string xeploai, string hoten, string phone) : base(hoten, phone)
        {
            this.masv = masv;
            this.diem = diem;
            this.xeploai = xeploai;
        }
        public override string ToString()
        {
            return string.Format("{0,-10}{1,-10}{2,-10}{3,-15}{4 , -10}", masv, diem,xeploai , HoTen , Phone);
        }


        public override bool Equals(object? obj)
        {
            SinhVien sv = (SinhVien)obj;
            return this.masv.Equals(sv.masv);
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine(" Nhap ma sinh vien : ");
            masv = Console.ReadLine();

            Console.WriteLine(" Nhap diem ");
            diem = double.Parse(Console.ReadLine());

        }
        //implement method để so sánh 
        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
    class SosanhtheoDiem : IComparer<SinhVien>
    {
        public int Compare(SinhVien? x, SinhVien? y)
        {
            throw new NotImplementedException();
        }
    }
}

