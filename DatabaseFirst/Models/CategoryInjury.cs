using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục tai nạn thương tích
/// </summary>
public partial class CategoryInjury
{
    public Guid InjuryId { get; set; }

    public string InjuryCode { get; set; } = null!;

    public string InjuryName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid? ConceptTypeId { get; set; }

    public virtual CategoryConceptType? ConceptType { get; set; }
}
