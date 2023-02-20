using System;
using System.Collections.Generic;

namespace BTVN_UseLNIQToSelect.Models;

public partial class Nhanvien
{
    public string Manv { get; set; } = null!;

    public string? Hoten { get; set; }

    public string? Ngaysinh { get; set; }

    public bool? Gioitinh { get; set; }

    public int? Hesoluong { get; set; }

    public string? Trinhdo { get; set; }

    public string? Madv { get; set; }

    public string? Macv { get; set; }

    public virtual Chucvu? MacvNavigation { get; set; }

    public virtual Donvi? MadvNavigation { get; set; }
}
