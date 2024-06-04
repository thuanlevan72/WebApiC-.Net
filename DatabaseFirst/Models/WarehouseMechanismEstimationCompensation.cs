using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Kho -  Cơ chế dự trù/Lĩnh bù
/// </summary>
public partial class WarehouseMechanismEstimationCompensation
{
    public Guid WarehouseMechanismEstimationCompensationId { get; set; }

    public Guid WarehouseId { get; set; }

    public Guid MechanismEstimationCompensationId { get; set; }

    public virtual CategoryAttribute MechanismEstimationCompensation { get; set; } = null!;

    public virtual CategoryWarehouse Warehouse { get; set; } = null!;
}
