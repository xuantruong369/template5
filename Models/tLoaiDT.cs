using System;
using System.Collections.Generic;

namespace Template5.Models;

public partial class tLoaiDT
{
    public string MaDT { get; set; } = null!;

    public string? TenLoai { get; set; }

    public virtual ICollection<tDanhMucSP> tDanhMucSPs { get; set; } = new List<tDanhMucSP>();
}
