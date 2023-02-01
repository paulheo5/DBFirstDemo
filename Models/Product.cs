using System;
using System.Collections.Generic;

namespace DBFirstDemo.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Price { get; set; }

    public DateTime Expiry { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
