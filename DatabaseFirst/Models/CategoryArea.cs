using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục khu vực
/// </summary>
public partial class CategoryArea
{
    public Guid AreaId { get; set; }

    /// <summary>
    /// mã khu vực
    /// </summary>
    public string AreaCode { get; set; } = null!;

    /// <summary>
    /// tên khu vực
    /// </summary>
    public string AreaName { get; set; } = null!;

    /// <summary>
    /// id tòa nhà
    /// </summary>
    public Guid BuildingId { get; set; }

    /// <summary>
    /// id đối tượng
    /// </summary>
    public Guid? ObjectAttributeId { get; set; }

    /// <summary>
    /// id loại đối tượng
    /// </summary>
    public Guid? ObjectTypeAttributeId { get; set; }

    /// <summary>
    /// id loại khu vực
    /// </summary>
    public Guid? AreaTypeAttributeId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public decimal? QuickSelectIndex { get; set; }

    public virtual CategoryAttribute? AreaTypeAttribute { get; set; }

    public virtual CategoryBuilding Building { get; set; } = null!;

    public virtual ICollection<CategoryCounter> CategoryCounters { get; set; } = new List<CategoryCounter>();

    public virtual ICollection<CategoryRoom> CategoryRooms { get; set; } = new List<CategoryRoom>();

    public virtual CategoryAttribute? ObjectAttribute { get; set; }

    public virtual CategoryAttribute? ObjectTypeAttribute { get; set; }
}
