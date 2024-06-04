using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thuốc  - nhóm chi phí
/// </summary>
public partial class DrugCostGroup
{
    public Guid DrugCostGroupId { get; set; }

    public Guid DrugId { get; set; }

    public Guid TabCostGroupId { get; set; }

    public virtual CategoryDrug Drug { get; set; } = null!;

    public virtual CategoryTabCostGroup TabCostGroup { get; set; } = null!;
}
