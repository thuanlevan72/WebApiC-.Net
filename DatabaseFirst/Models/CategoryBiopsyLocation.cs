using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục vị trí sinh thiết
/// </summary>
public partial class CategoryBiopsyLocation
{
    public Guid BiopsyLocaltionId { get; set; }

    /// <summary>
    /// mã
    /// </summary>
    public string BiopsyLocaltionCode { get; set; } = null!;

    /// <summary>
    /// tên
    /// </summary>
    public string BiopsyLocaltionName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }
}
