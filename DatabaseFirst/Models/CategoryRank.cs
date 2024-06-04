using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục quân hàm
/// </summary>
public partial class CategoryRank
{
    public Guid RankId { get; set; }

    /// <summary>
    /// mã quân hàm
    /// </summary>
    public string RankCode { get; set; } = null!;

    /// <summary>
    /// Tên quân hàm
    /// </summary>
    public string RankName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }
}
