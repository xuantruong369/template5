using System;
using System.Collections.Generic;

namespace Template5.Models;

public partial class tQuocGium
{
    public string MaNuoc { get; set; } = null!;

    public string? TenNuoc { get; set; }

    public virtual ICollection<tDanhMucSP> tDanhMucSPs { get; set; } = new List<tDanhMucSP>();
}
