using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Quầy - Loại quầy
/// </summary>
public partial class CounterCounterType
{
    public Guid CounterCounterType1 { get; set; }

    public Guid CounterId { get; set; }

    public Guid CounterTypeId { get; set; }

    public virtual CategoryCounter Counter { get; set; } = null!;

    public virtual CategoryAttribute CounterType { get; set; } = null!;
}
