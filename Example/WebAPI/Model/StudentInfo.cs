using System;
using System.Collections.Generic;

namespace WebAPI.Model;

public partial class StudentInfo
{
    public int StudantId { get; set; }

    public string Sname { get; set; } = null!;

    public string Sdept { get; set; } = null!;

    public string EmailId { get; set; } = null!;

    public string Slocation { get; set; } = null!;
}
