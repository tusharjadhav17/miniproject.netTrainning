using System;
using System.Collections.Generic;

namespace MyConsoleAppEFA.Model;

public partial class Student
{
    public int StudentId { get; set; }

    public string Sname { get; set; } = null!;

    public long? Age { get; set; }

    public int DeptId { get; set; }

    public string Location { get; set; } = null!;

    public string? Email { get; set; }
}
