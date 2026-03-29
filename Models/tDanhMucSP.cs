using System;
using System.Collections.Generic;

namespace Template5.Models;

public partial class tDanhMucSP
{
    public string MaSP { get; set; } = null!;

    public string? TenSP { get; set; }

    public string? MaChatLieu { get; set; }

    public string? NganLapTop { get; set; }

    public string? Model { get; set; }

    public double? CanNang { get; set; }

    public double? DoNoi { get; set; }

    public string? MaHangSX { get; set; }

    public string? MaNuocSX { get; set; }

    public string? MaDacTinh { get; set; }

    public string? Website { get; set; }

    public double? ThoiGianBaoHanh { get; set; }

    public string? GioiThieuSP { get; set; }

    public double? ChietKhau { get; set; }

    public string? MaLoai { get; set; }

    public string? MaDT { get; set; }

    public string? AnhDaiDien { get; set; }

    public decimal? GiaNhoNhat { get; set; }

    public decimal? GiaLonNhat { get; set; }

    public virtual tChatLieu? MaChatLieuNavigation { get; set; }

    public virtual tLoaiDT? MaDTNavigation { get; set; }

    public virtual tHangSX? MaHangSXNavigation { get; set; }

    public virtual tLoaiSP? MaLoaiNavigation { get; set; }

    public virtual tQuocGium? MaNuocSXNavigation { get; set; }

    public virtual ICollection<tAnhSP> tAnhSPs { get; set; } = new List<tAnhSP>();

    public virtual ICollection<tChiTietSanPham> tChiTietSanPhams { get; set; } = new List<tChiTietSanPham>();
}
