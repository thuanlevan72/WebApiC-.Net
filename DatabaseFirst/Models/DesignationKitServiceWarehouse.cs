using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ trong bộ - kho
/// </summary>
public partial class DesignationKitServiceWarehouse
{
    public Guid DesignationKitServiceWarehouseId { get; set; }

    public Guid DesignationKitServiceId { get; set; }

    public Guid WarehouseId { get; set; }

    public virtual CategoryDesignationKitService DesignationKitService { get; set; } = null!;

    public virtual CategoryWarehouse Warehouse { get; set; } = null!;
}
