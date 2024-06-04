using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Quản trị kho - Nhân viên quản lý
/// </summary>
public partial class WarehouseAccount
{
    public Guid WarehouseAccountId { get; set; }

    /// <summary>
    /// Kho
    /// </summary>
    public Guid WarehouseId { get; set; }

    /// <summary>
    /// tài khoản
    /// </summary>
    public Guid AccountId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategoryAccount Account { get; set; } = null!;

    public virtual CategoryWarehouse Warehouse { get; set; } = null!;
}
