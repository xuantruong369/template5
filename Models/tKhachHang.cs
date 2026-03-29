using System;
using System.Collections.Generic;

namespace Template5.Models;

public partial class tKhachHang
{
    public string MaKhanhHang { get; set; } = null!;

    public string? username { get; set; }

    public string? TenKhachHang { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public string? SoDienThoai { get; set; }

    public string? DiaChi { get; set; }

    public byte? LoaiKhachHang { get; set; }

    public string? AnhDaiDien { get; set; }

    public string? GhiChu { get; set; }

    public virtual ICollection<tHoaDonBan> tHoaDonBans { get; set; } = new List<tHoaDonBan>();

    public virtual tUser? usernameNavigation { get; set; }
}
