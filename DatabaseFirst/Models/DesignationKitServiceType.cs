using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Bộ chỉ định - Loại dịch vụ
/// </summary>
public partial class DesignationKitServiceType
{
    public Guid DesignationKitServiceTypeId { get; set; }

    public Guid DesignationKitId { get; set; }

    public Guid ServiceTypeConceptId { get; set; }

    public virtual CategoryDesignationKit DesignationKit { get; set; } = null!;

    public virtual CategoryConcept ServiceTypeConcept { get; set; } = null!;
}
