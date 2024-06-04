using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Xét nghiệm - chỉ số con
/// </summary>
public partial class LaboratoryServiceTabChildIndex
{
    public Guid LaboratoryServiceTabChildIndexId { get; set; }

    public Guid LaboratoryServiceId { get; set; }

    public Guid TabChildIndexId { get; set; }

    public virtual CategoryLaboratoryService LaboratoryService { get; set; } = null!;

    public virtual CategoryTabChildIndex TabChildIndex { get; set; } = null!;
}
