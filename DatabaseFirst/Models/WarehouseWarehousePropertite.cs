using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Kho - Tính chất kho
/// </summary>
public partial class WarehouseWarehousePropertite
{
    public Guid WarehouseWarehousePropertitiesId { get; set; }

    public Guid WarehouseId { get; set; }

    public Guid WarehousePropertitiesId { get; set; }

    public virtual CategoryWarehouse Warehouse { get; set; } = null!;

    public virtual CategoryAttribute WarehousePropertities { get; set; } = null!;
}
