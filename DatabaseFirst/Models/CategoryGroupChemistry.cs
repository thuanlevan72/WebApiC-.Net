using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nhóm hóa chất
/// </summary>
public partial class CategoryGroupChemistry
{
    public Guid GroupChemistriesId { get; set; }

    /// <summary>
    /// mã nhóm hóa chất
    /// </summary>
    public string GroupChemistriesCode { get; set; } = null!;

    /// <summary>
    /// Tên nhóm hóa chất
    /// </summary>
    public string GroupChemistriesName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CategoryChemistry> CategoryChemistries { get; set; } = new List<CategoryChemistry>();
}
