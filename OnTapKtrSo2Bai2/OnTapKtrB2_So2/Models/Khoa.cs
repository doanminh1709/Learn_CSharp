using System;
using System.Collections.Generic;

#nullable disable

namespace OnTapKtrB2_So2.Models
{
    public partial class Khoa
    {
        public Khoa()
        {
            SinhViens = new HashSet<SinhVien>();
        }

        public string Makhoa { get; set; }
        public string Tenkhoa { get; set; }

        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
