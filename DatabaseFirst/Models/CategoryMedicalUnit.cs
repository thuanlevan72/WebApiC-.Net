using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục đơn vị y tế
/// </summary>
public partial class CategoryMedicalUnit
{
    public Guid MedicalUnitId { get; set; }

    /// <summary>
    /// mã đơn vị y tế
    /// </summary>
    public string MedicalUnitCode { get; set; } = null!;

    /// <summary>
    /// tên đơn vị y tế
    /// </summary>
    public string MedicalUnitName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryBranch> CategoryBranches { get; set; } = new List<CategoryBranch>();
}
