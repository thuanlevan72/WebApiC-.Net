using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phân nhóm thuốc
/// </summary>
public partial class CategoryDrugGrouping
{
    public Guid DrugGroupingId { get; set; }

    /// <summary>
    /// mã nhóm thuốc
    /// </summary>
    public string DrupGroupingCode { get; set; } = null!;

    /// <summary>
    /// tên nhóm thuốc
    /// </summary>
    public string DrugGroupingName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryDrug> CategoryDrugs { get; set; } = new List<CategoryDrug>();
}
