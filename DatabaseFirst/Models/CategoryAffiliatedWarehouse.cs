using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Kho Trực Thuộc
/// </summary>
public partial class CategoryAffiliatedWarehouse
{
    public Guid AfiliatedWarehouseId { get; set; }

    public Guid AfiliatedId { get; set; }

    public Guid WarehouseId { get; set; }

    public int? IsActive { get; set; }

    public virtual CategoryWarehouse Afiliated { get; set; } = null!;

    public virtual CategoryWarehouse Warehouse { get; set; } = null!;
}
