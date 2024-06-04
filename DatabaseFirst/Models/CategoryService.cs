using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục dịch vụ
/// </summary>
public partial class CategoryService
{
    public Guid ServiceId { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public string? ServiceName { get; set; }

    public Guid? ConceptId { get; set; }

    public virtual ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();

    public virtual CategoryConcept? Concept { get; set; }

    public virtual ICollection<ServiceConcept> ServiceConcepts { get; set; } = new List<ServiceConcept>();
}
