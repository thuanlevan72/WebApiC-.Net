using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Vật tư -  nhóm chi phí
/// </summary>
public partial class SuppliesCostGroup
{
    public Guid SuppliesCostGroupId { get; set; }

    public Guid SuppliesId { get; set; }

    public Guid TabCostGroupId { get; set; }

    public virtual CategorySupply Supplies { get; set; } = null!;

    public virtual CategoryTabCostGroup TabCostGroup { get; set; } = null!;
}
