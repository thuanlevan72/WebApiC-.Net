using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục mức độ tương tác
/// </summary>
public partial class CategoryLevelOfInteraction
{
    public Guid LevelOfInteractionId { get; set; }

    public string LevelOfInteractionCode { get; set; } = null!;

    public string LevelOfInteractionName { get; set; } = null!;

    public string LevelOfInteractionColor { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryReportDrugInteraction> CategoryReportDrugInteractions { get; set; } = new List<CategoryReportDrugInteraction>();
}
