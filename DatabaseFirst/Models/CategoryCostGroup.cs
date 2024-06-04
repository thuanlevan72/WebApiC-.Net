using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nhóm chi phí
/// </summary>
public partial class CategoryCostGroup
{
    public Guid CostGroupId { get; set; }

    /// <summary>
    /// mã nhóm chi phí
    /// </summary>
    public string CostGroupCode { get; set; } = null!;

    /// <summary>
    /// tên nhóm chi phí
    /// </summary>
    public string CostGroupName { get; set; } = null!;

    /// <summary>
    /// mô tả nhóm chi phí
    /// </summary>
    public string CostGroupDesc { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CategoryBidDetail> CategoryBidDetails { get; set; } = new List<CategoryBidDetail>();

    public virtual ICollection<CategoryTabCostGroup> CategoryTabCostGroups { get; set; } = new List<CategoryTabCostGroup>();
}
