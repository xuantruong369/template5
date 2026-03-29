using System;
using System.Collections.Generic;

namespace Template5.Models;

public partial class tLoaiSP
{
    public string MaLoai { get; set; } = null!;

    public string? Loai { get; set; }

    public virtual ICollection<tDanhMucSP> tDanhMucSPs { get; set; } = new List<tDanhMucSP>();
}
