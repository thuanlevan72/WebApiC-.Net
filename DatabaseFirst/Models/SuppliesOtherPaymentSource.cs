using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Vật tư - nguồn chi trả khác
/// </summary>
public partial class SuppliesOtherPaymentSource
{
    public Guid SuppliesOtherPaymentSourceId { get; set; }

    public Guid SuppliesId { get; set; }

    public Guid OtherPaymentSourceAttributeId { get; set; }

    public virtual CategoryAttribute OtherPaymentSourceAttribute { get; set; } = null!;

    public virtual CategorySupply Supplies { get; set; } = null!;
}
