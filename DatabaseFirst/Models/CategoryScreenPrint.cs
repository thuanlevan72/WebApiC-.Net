using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// danh mic màn hình phiếu in
/// </summary>
public partial class CategoryScreenPrint
{
    public Guid ScreenPrintId { get; set; }

    /// <summary>
    /// mã màn hình
    /// </summary>
    public string ScreenPrintCode { get; set; } = null!;

    /// <summary>
    /// tên màn hình
    /// </summary>
    public string ScreenPrintName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryPositionPrint> CategoryPositionPrints { get; set; } = new List<CategoryPositionPrint>();
}
