using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục xuất xứ
/// </summary>
public partial class CategoryOrigin
{
    public Guid OriginId { get; set; }

    /// <summary>
    /// mã xuất xứ
    /// </summary>
    public string OriginCode { get; set; } = null!;

    /// <summary>
    /// tên xuất xứ
    /// </summary>
    public string OriginName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryBidDetail> CategoryBidDetails { get; set; } = new List<CategoryBidDetail>();
}
