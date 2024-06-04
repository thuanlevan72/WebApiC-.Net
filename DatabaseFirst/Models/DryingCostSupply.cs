using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chi phí hấp sấy - vật tư
/// </summary>
public partial class DryingCostSupply
{
    public Guid DryingCostSuppliesId { get; set; }

    public Guid SuppliesId { get; set; }

    public Guid DryingCostId { get; set; }

    public virtual CategoryDryingCost DryingCost { get; set; } = null!;

    public virtual CategorySupply Supplies { get; set; } = null!;
}
