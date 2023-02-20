using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapWFP
{
    internal class SinhVien
    {
        private String masv;

        private String tensv;

        private float diem;

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
        public float Diem
        {
            get { return diem; }
            set { diem = value; }
        }
        public SinhVien()
        {
            masv = "";
            tensv = "";
            diem = 0;
        }
        public SinhVien(string masv)
        {
            this.masv = masv;
        }
        public SinhVien(String masv, String tensv, float diem)
        {
            this.masv = masv;
            this.tensv = tensv;
            this.diem = diem;
        }

        public override bool Equals(object obj)
        {
            SinhVien sv = obj as SinhVien;
            return this.MaSv.Equals(sv.masv);
        }
    }
}

