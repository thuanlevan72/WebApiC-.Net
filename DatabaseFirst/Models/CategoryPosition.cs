using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục chức vụ
/// </summary>
public partial class CategoryPosition
{
    public Guid PositionId { get; set; }

    /// <summary>
    /// mã chức vụ
    /// </summary>
    public string PositionCode { get; set; } = null!;

    /// <summary>
    /// tên chức vụ
    /// </summary>
    public string PositionName { get; set; } = null!;

    /// <summary>
    /// ghi chú
    /// </summary>
    public string Note { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CategoryEmployee> CategoryEmployees { get; set; } = new List<CategoryEmployee>();

    public virtual ICollection<CategorySetUpDesignatedWarehouse> CategorySetUpDesignatedWarehouses { get; set; } = new List<CategorySetUpDesignatedWarehouse>();
}
