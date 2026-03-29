using System;
using System.Collections.Generic;

namespace Template5.Models;

public partial class tHoaDonBan
{
    public string MaHoaDon { get; set; } = null!;

    public DateTime? NgayHoaDon { get; set; }

    public string? MaKhachHang { get; set; }

    public string? MaNhanVien { get; set; }

    public decimal? TongTienHD { get; set; }

    public double? GiamGiaHD { get; set; }

    public byte? PhuongThucThanhToan { get; set; }

    public string? MaSoThue { get; set; }

    public string? ThongTinThue { get; set; }

    public string? GhiChu { get; set; }

    public virtual tKhachHang? MaKhachHangNavigation { get; set; }

    public virtual tNhanVien? MaNhanVienNavigation { get; set; }

    public virtual ICollection<tChiTietHDB> tChiTietHDBs { get; set; } = new List<tChiTietHDB>();
}
