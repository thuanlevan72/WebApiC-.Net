using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// CDHATDCN - Nhóm chi phí
/// </summary>
public partial class CdhatdcnTabCostGroup
{
    public Guid CdhaTdcnTabCostGroupId { get; set; }

    public Guid CdhaTdcnId { get; set; }

    public Guid TabCostGroupId { get; set; }

    public virtual CategoryCdhatdcn CdhaTdcn { get; set; } = null!;

    public virtual CategoryTabCostGroup TabCostGroup { get; set; } = null!;
}
