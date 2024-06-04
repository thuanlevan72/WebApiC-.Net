using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Lịch sử tồn kho
/// </summary>
public partial class CategoryInventoryHistory
{
    public Guid InventoryHistoryId { get; set; }

    public Guid InventoryId { get; set; }

    public int QtyOld { get; set; }

    public int QtyNew { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual CategoryInventory Inventory { get; set; } = null!;
}
