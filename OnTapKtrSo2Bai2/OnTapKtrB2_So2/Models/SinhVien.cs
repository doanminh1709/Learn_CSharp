using System;
using System.Collections.Generic;

#nullable disable

namespace OnTapKtrB2_So2.Models
{
    public partial class SinhVien
    {
        public string Masv { get; set; }
        public string Tensv { get; set; }
        public string Quequan { get; set; }
        public string Makhoa { get; set; }
        public double? DiemTk { get; set; }

        public virtual Khoa MakhoaNavigation { get; set; }
    }
}
