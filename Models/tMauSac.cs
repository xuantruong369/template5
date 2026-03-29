using System;
using System.Collections.Generic;

namespace Template5.Models;

public partial class tMauSac
{
    public string MaMauSac { get; set; } = null!;

    public string? TenMauSac { get; set; }

    public virtual ICollection<tChiTietSanPham> tChiTietSanPhams { get; set; } = new List<tChiTietSanPham>();
}
