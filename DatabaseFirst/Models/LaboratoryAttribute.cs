using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Xét nghiệm - Thuộc tính
/// </summary>
public partial class LaboratoryAttribute
{
    public Guid LaboratoryAttributeId { get; set; }

    public Guid LaboratoryId { get; set; }

    public Guid AttributeId { get; set; }

    public virtual CategoryAttribute Attribute { get; set; } = null!;

    public virtual CategoryLaboratoryService Laboratory { get; set; } = null!;
}
