using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// chỉ số con
/// </summary>
public partial class LaboratoryResultTemplateTabChildIndex
{
    public Guid LaboratoryResultTemplateChildIndexId { get; set; }

    public Guid LaboratoryResultTemplateId { get; set; }

    public Guid TabChildIndexId { get; set; }

    public virtual CategoryLaboratoryResultTemplate LaboratoryResultTemplate { get; set; } = null!;

    public virtual CategoryTabChildIndex TabChildIndex { get; set; } = null!;
}
