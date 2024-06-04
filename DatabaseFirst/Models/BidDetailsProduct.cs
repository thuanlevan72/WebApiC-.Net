using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chi tiết thầu - Hàng hóa
/// </summary>
public partial class BidDetailsProduct
{
    public Guid BidDetailProductId { get; set; }

    public Guid ProductId { get; set; }

    public Guid BidDetailsId { get; set; }

    public virtual CategoryBidDetail BidDetails { get; set; } = null!;

    public virtual CategoryProduct Product { get; set; } = null!;
}
