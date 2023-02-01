using System;
using System.Collections.Generic;

namespace DBFirstDemo.Models;

public partial class Food
{
    public string Food1 { get; set; } = null!;

    public double? Price { get; set; }

    public string? Location { get; set; }
}
