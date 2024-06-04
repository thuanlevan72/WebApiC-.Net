using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// danh mục phiếu in
/// </summary>
public partial class CategoryVotePrint
{
    public Guid PrintId { get; set; }

    /// <summary>
    /// mã phiếu
    /// </summary>
    public string PrintCode { get; set; } = null!;

    /// <summary>
    /// tên phiếu
    /// </summary>
    public string PrintName { get; set; } = null!;

    /// <summary>
    /// vị trí
    /// </summary>
    public Guid PositionPrintId { get; set; }

    /// <summary>
    /// báo cáo
    /// </summary>
    public Guid? ReportId { get; set; }

    /// <summary>
    /// stt phiếu
    /// </summary>
    public int? NumberPrint { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategoryPositionPrint PositionPrint { get; set; } = null!;

    public virtual CategoryReport? Report { get; set; }
}
