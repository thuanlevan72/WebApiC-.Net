using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Gói dịch vụ - Loại Dịch vụ
/// </summary>
public partial class PackageServiceConcept
{
    public Guid PackageServiceConceptId { get; set; }

    public Guid PackageServiceId { get; set; }

    public Guid ConceptId { get; set; }

    public virtual CategoryConcept Concept { get; set; } = null!;

    public virtual CategoryPackageService PackageService { get; set; } = null!;
}
