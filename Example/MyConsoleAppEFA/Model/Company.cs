using System;
using System.Collections.Generic;

namespace MyConsoleAppEFA.Model;

public partial class Company
{
    public long CompId { get; set; }

    public string CompName { get; set; } = null!;

    public string CompAddress { get; set; } = null!;

    public string CompEmail { get; set; } = null!;

    public long CompPhone { get; set; }
}
