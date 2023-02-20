using System;
using System.Collections.Generic;

namespace BTVN_UseLNIQToSelect.Models;

public partial class Chucvu
{
    public string Macv { get; set; } = null!;

    public string Tencv { get; set; } = null!;

    public double Phucap { get; set; }

    public virtual ICollection<Nhanvien> Nhanviens { get; } = new List<Nhanvien>();
}
