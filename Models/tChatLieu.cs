using System;
using System.Collections.Generic;

namespace Template5.Models;

public partial class tChatLieu
{
    public string MaChatLieu { get; set; } = null!;

    public string? ChatLieu { get; set; }

    public virtual ICollection<tDanhMucSP> tDanhMucSPs { get; set; } = new List<tDanhMucSP>();
}
