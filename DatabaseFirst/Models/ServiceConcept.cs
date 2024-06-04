using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ -concecpt
/// </summary>
public partial class ServiceConcept
{
    public Guid ServiceConceptId { get; set; }

    public Guid ServiceId { get; set; }

    public Guid ConceptId { get; set; }

    public virtual CategoryConcept Concept { get; set; } = null!;

    public virtual CategoryService Service { get; set; } = null!;
}
