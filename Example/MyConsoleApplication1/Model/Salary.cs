using System;
using System.Collections.Generic;

namespace MyConsoleApplication1.Model;

public partial class Salary
{
    public string? Gread { get; set; }

    public decimal MinSalary { get; set; }

    public decimal MaxSalary { get; set; }

    public long EmpId { get; set; }
}
