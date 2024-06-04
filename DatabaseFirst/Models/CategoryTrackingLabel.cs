using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nhãn theo dõi
/// </summary>
public partial class CategoryTrackingLabel
{
    public Guid TrackingLabelId { get; set; }

    /// <summary>
    /// mã nhãn theo dõi
    /// </summary>
    public string TrackingLabelCode { get; set; } = null!;

    /// <summary>
    /// tên nhãn theo dõi
    /// </summary>
    public string TrackingLabelName { get; set; } = null!;

    /// <summary>
    /// ký hiệu  nhãn theo dõi
    /// </summary>
    public string? TrackingLabelSymbol { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }
}
