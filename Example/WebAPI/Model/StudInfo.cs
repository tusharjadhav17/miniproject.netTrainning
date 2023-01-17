using System;
using System.Collections.Generic;

namespace WebAPI.Model;

public partial class StudInfo
{
    public long StudId { get; set; }

    public string StudName { get; set; } = null!;

    public string StudDept { get; set; } = null!;

    public string StudEmail { get; set; } = null!;

    public string StudLocation { get; set; } = null!;
}
