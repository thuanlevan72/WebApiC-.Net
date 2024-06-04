using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Gói mổ 10 ngày - danh mục chung
/// </summary>
public partial class SurgeryPackageGeneralService
{
    public Guid SurgeryPackageGeneralServiceId { get; set; }

    public Guid SurgeryPackageId { get; set; }

    public Guid ConceptId { get; set; }

    public virtual CategoryConcept Concept { get; set; } = null!;

    public virtual Category10daySurgeryPackage SurgeryPackage { get; set; } = null!;
}
