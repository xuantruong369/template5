using System;
using System.Collections.Generic;

namespace Template5.Models;

public partial class tHangSX
{
    public string MaHangSX { get; set; } = null!;

    public string? HangSX { get; set; }

    public string? MaNuocThuongHieu { get; set; }

    public virtual ICollection<tDanhMucSP> tDanhMucSPs { get; set; } = new List<tDanhMucSP>();
}
