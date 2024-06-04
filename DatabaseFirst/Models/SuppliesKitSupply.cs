using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Vật tư - Vật tư bộ
/// </summary>
public partial class SuppliesKitSupply
{
    public Guid SuppliesKitSuppliesId { get; set; }

    public Guid SuppliesId { get; set; }

    public Guid KitSuppliesId { get; set; }

    public virtual CategoryKitSupply KitSupplies { get; set; } = null!;

    public virtual CategorySupply Supplies { get; set; } = null!;
}
