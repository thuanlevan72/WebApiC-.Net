using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nhóm thuốc
/// </summary>
public partial class CategoryGroupDrug
{
    public Guid GroupDrugId { get; set; }

    /// <summary>
    /// danh mục cha:
    /// </summary>
    public Guid? ParentId { get; set; }

    /// <summary>
    /// mã nhóm thuốc
    /// </summary>
    public string GroupDrugCode { get; set; } = null!;

    /// <summary>
    /// tên nhóm thuốc
    /// </summary>
    public string GroupDrugName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CategoryDrug> CategoryDrugs { get; set; } = new List<CategoryDrug>();
}
