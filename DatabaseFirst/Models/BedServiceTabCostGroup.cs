using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ giường - Nhóm chi phí
/// </summary>
public partial class BedServiceTabCostGroup
{
    public Guid BedServiceTabCostGroupId { get; set; }

    public Guid BedServiceId { get; set; }

    public Guid TabCostGroupId { get; set; }

    public virtual CategoryBedService BedService { get; set; } = null!;

    public virtual CategoryTabCostGroup TabCostGroup { get; set; } = null!;
}
