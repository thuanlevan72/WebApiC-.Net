using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh sách tồn kho
/// </summary>
public partial class CategoryInventory
{
    public Guid InventoryId { get; set; }

    /// <summary>
    /// kho
    /// </summary>
    public Guid WarehouseId { get; set; }

    /// <summary>
    /// hàng hóa
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// sl tồn thực tế( thứ cấp)
    /// </summary>
    public int QtyInventoryActual { get; set; }

    /// <summary>
    /// số lượng tồn thực tế sơ cấp
    /// </summary>
    public int QtyInventoryActualPrimary { get; set; }

    /// <summary>
    /// số  lượng tồn khả dụng(thứ cấp)
    /// </summary>
    public int QtyInventoryAvaiable { get; set; }

    /// <summary>
    /// số lượng tồn khả dụng sơ cấp
    /// </summary>
    public int QtyInventoryAvaiablePrimary { get; set; }

    /// <summary>
    /// sl giữ chỗ thứ cấp
    /// </summary>
    public int QtyOrder { get; set; }

    /// <summary>
    /// sl giữ chỗ sơ cấp
    /// </summary>
    public int QtyOrderPrimary { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<CategoryInventoryHistory> CategoryInventoryHistories { get; set; } = new List<CategoryInventoryHistory>();

    public virtual CategoryProduct Product { get; set; } = null!;

    public virtual CategoryWarehouse Warehouse { get; set; } = null!;
}
