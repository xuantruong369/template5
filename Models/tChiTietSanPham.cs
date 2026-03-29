using System;
using System.Collections.Generic;

namespace Template5.Models;

public partial class tChiTietSanPham
{
    public string MaChiTietSP { get; set; } = null!;

    public string? MaSP { get; set; }

    public string? MaKichThuoc { get; set; }

    public string? MaMauSac { get; set; }

    public string? AnhDaiDien { get; set; }

    public string? Video { get; set; }

    public double? DonGiaBan { get; set; }

    public double? GiamGia { get; set; }

    public int? SLTon { get; set; }

    public virtual tKichThuoc? MaKichThuocNavigation { get; set; }

    public virtual tMauSac? MaMauSacNavigation { get; set; }

    public virtual tDanhMucSP? MaSPNavigation { get; set; }

    public virtual ICollection<tAnhChiTietSP> tAnhChiTietSPs { get; set; } = new List<tAnhChiTietSP>();

    public virtual ICollection<tChiTietHDB> tChiTietHDBs { get; set; } = new List<tChiTietHDB>();
}
