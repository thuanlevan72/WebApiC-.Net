using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nhóm chỉ số
/// </summary>
public partial class CategoryIndexGroup
{
    public Guid IndexGroupId { get; set; }

    /// <summary>
    /// mã
    /// </summary>
    public string IndexGroupCode { get; set; } = null!;

    /// <summary>
    /// tên
    /// </summary>
    public string IndexGroupName { get; set; } = null!;

    /// <summary>
    /// Mô tả
    /// </summary>
    public string? IndexGroupDesc { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public int? IsActive { get; set; }
}
