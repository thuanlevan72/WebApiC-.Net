using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phẫu thuật thủ thuật - Thuộc tính
/// </summary>
public partial class SurgicalProcedureAttribute
{
    public Guid SurgicalProcedureAttributeId { get; set; }

    public Guid SurgicalProcedureId { get; set; }

    public Guid AttributeId { get; set; }

    public virtual CategoryAttribute Attribute { get; set; } = null!;

    public virtual CategorySurgicalProceduresService SurgicalProcedure { get; set; } = null!;
}
