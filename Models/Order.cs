using System;
using System.Collections.Generic;

namespace DBFirstDemo.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int OrderNumber { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public virtual Product? Product { get; set; }
}
