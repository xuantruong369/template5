using System;
using System.Collections.Generic;

namespace Template5.Models;

public partial class tChiTietHDB
{
    public string MaHoaDon { get; set; } = null!;

    public string MaChiTietSP { get; set; } = null!;

    public int? SoLuongBan { get; set; }

    public decimal? DonGiaBan { get; set; }

    public double? GiamGia { get; set; }

    public string? GhiChu { get; set; }

    public virtual tChiTietSanPham MaChiTietSPNavigation { get; set; } = null!;

    public virtual tHoaDonBan MaHoaDonNavigation { get; set; } = null!;
}
