using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục kháng nguyên
/// </summary>
public partial class CategoryAntigen
{
    public Guid AntigenId { get; set; }

    /// <summary>
    /// mã kháng nguyên
    /// </summary>
    public string AntigenCode { get; set; } = null!;

    /// <summary>
    /// tên kháng nguyên
    /// </summary>
    public string AntigenName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangeBy { get; set; }

    public virtual ICollection<CategoryVaccine> CategoryVaccines { get; set; } = new List<CategoryVaccine>();
}
