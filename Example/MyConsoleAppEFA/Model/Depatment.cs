using System;
using System.Collections.Generic;

namespace MyConsoleAppEFA.Model;

public partial class Depatment
{
    public long DeptId { get; set; }

    public string? DeptName { get; set; }

    public string? DeptLocation { get; set; }

    public long EmpId { get; set; }
}
