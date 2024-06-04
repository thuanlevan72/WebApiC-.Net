using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Hóa chất - nhóm chi phí
/// </summary>
public partial class ChemistyCostGroup
{
    public Guid ChemistryCostGroupId { get; set; }

    public Guid ChemistriesId { get; set; }

    public Guid TabCostGroupId { get; set; }

    public virtual CategoryChemistry Chemistries { get; set; } = null!;

    public virtual CategoryTabCostGroup TabCostGroup { get; set; } = null!;
}
