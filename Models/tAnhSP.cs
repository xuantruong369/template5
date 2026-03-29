using System;
using System.Collections.Generic;

namespace Template5.Models;

public partial class tAnhSP
{
    public string MaSP { get; set; } = null!;

    public string TenFileAnh { get; set; } = null!;

    public short? ViTri { get; set; }

    public virtual tDanhMucSP MaSPNavigation { get; set; } = null!;
}
