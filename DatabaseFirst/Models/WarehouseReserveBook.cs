using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Kho - Giữ chỗ ngay khi kê
/// </summary>
public partial class WarehouseReserveBook
{
    public Guid WarehouseReserveBookId { get; set; }

    public Guid WarehouseId { get; set; }

    public Guid ReserveBookId { get; set; }

    public virtual CategoryAttribute ReserveBook { get; set; } = null!;

    public virtual CategoryWarehouse Warehouse { get; set; } = null!;
}
