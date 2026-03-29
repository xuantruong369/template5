using System;
using System.Collections.Generic;

namespace Template5.Models;

public partial class tUser
{
    public string username { get; set; } = null!;

    public string password { get; set; } = null!;

    public byte? LoaiUser { get; set; }

    public virtual ICollection<tKhachHang> tKhachHangs { get; set; } = new List<tKhachHang>();

    public virtual ICollection<tNhanVien> tNhanViens { get; set; } = new List<tNhanVien>();
}
