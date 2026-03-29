using System;
using System.Collections.Generic;

namespace Template5.Models;

public partial class tNhanVien
{
    public string MaNhanVien { get; set; } = null!;

    public string? username { get; set; }

    public string? TenNhanVien { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public string? SoDienThoai1 { get; set; }

    public string? SoDienThoai2 { get; set; }

    public string? DiaChi { get; set; }

    public string? ChucVu { get; set; }

    public string? AnhDaiDien { get; set; }

    public string? GhiChu { get; set; }

    public virtual ICollection<tHoaDonBan> tHoaDonBans { get; set; } = new List<tHoaDonBan>();

    public virtual tUser? usernameNavigation { get; set; }
}
