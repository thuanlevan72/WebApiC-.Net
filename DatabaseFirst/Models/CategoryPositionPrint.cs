using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục vị trí máy in
/// </summary>
public partial class CategoryPositionPrint
{
    public Guid PositionPrintId { get; set; }

    /// <summary>
    /// mã vị trí
    /// </summary>
    public string PositionPrintCode { get; set; } = null!;

    /// <summary>
    /// tên vị trí
    /// </summary>
    public string PositionPrintName { get; set; } = null!;

    /// <summary>
    /// màn hình
    /// </summary>
    public Guid ScreenPrintId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CategoryVotePrint> CategoryVotePrints { get; set; } = new List<CategoryVotePrint>();

    public virtual CategoryScreenPrint ScreenPrint { get; set; } = null!;
}
