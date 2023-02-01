using System;
using System.Collections.Generic;

namespace DBFirstDemo.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Company { get; set; } = null!;

    public DateTime Expiry { get; set; }
}
