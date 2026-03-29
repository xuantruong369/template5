using System;
using System.Collections.Generic;

namespace Template5.Models;

public partial class tAnhChiTietSP
{
    public string MaChiTietSP { get; set; } = null!;

    public string TenFileAnh { get; set; } = null!;

    public short? ViTri { get; set; }

    public virtual tChiTietSanPham MaChiTietSPNavigation { get; set; } = null!;
}
