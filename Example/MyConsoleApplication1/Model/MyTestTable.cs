using System;
using System.Collections.Generic;

namespace MyConsoleApplication1.Model;

public partial class MyTestTable
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime? UpdateAt { get; set; }
}
