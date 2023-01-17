using System;
using System.Collections.Generic;

namespace MyConsoleApplication1.Model;

public partial class Employee
{
    public long EmpId { get; set; }

    public string? JobName { get; set; }

    public string? EmpName { get; set; }

    public string Email { get; set; } = null!;

    public decimal Salary { get; set; }

    public string Address { get; set; } = null!;

    public string DeptId { get; set; } = null!;
}
