using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục hậu quả tương tác
/// </summary>
public partial class CategoryInteractionConsequence
{
    public Guid InteractionConsequencesId { get; set; }

    /// <summary>
    /// mã hậu quả
    /// </summary>
    public string InteractionConsequencesCode { get; set; } = null!;

    /// <summary>
    /// tên hậu quả
    /// </summary>
    public string InteractionConsequencesName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryReportDrugInteraction> CategoryReportDrugInteractions { get; set; } = new List<CategoryReportDrugInteraction>();
}
