using System;
using System.Collections.Generic;

namespace BTVN_UseLNIQToSelect.Models;

public partial class Donvi
{
    public string Madv { get; set; } = null!;

    public string Tendv { get; set; } = null!;

    public string? Dienthoai { get; set; }

    public virtual ICollection<Nhanvien> Nhanviens { get; } = new List<Nhanvien>();
}
