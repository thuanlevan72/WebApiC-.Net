using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thuộc tính - cdha
/// </summary>
public partial class CdhaAttribute
{
    public Guid CdhaAttributeId { get; set; }

    public Guid CdhaId { get; set; }

    public Guid AttributeId { get; set; }

    public virtual CategoryAttribute Attribute { get; set; } = null!;

    public virtual CategoryCdhatdcn Cdha { get; set; } = null!;
}
