using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục Loại dịch vụ
/// </summary>
public partial class CategoryConceptType
{
    public Guid ConceptTypeId { get; set; }

    public string ConceptTypeName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid? ConceptId { get; set; }

    public virtual ICollection<CategoryInjury> CategoryInjuries { get; set; } = new List<CategoryInjury>();

    public virtual CategoryConcept? Concept { get; set; }
}
