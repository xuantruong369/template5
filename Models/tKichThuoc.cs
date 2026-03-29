using System;
using System.Collections.Generic;

namespace Template5.Models;

public partial class tKichThuoc
{
    public string MaKichThuoc { get; set; } = null!;

    public string? KichThuoc { get; set; }

    public virtual ICollection<tChiTietSanPham> tChiTietSanPhams { get; set; } = new List<tChiTietSanPham>();
}
