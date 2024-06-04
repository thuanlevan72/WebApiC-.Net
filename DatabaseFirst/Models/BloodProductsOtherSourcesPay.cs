using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chế phẩm máu - Nguồn chi trả khác
/// </summary>
public partial class BloodProductsOtherSourcesPay
{
    public Guid BloodProductsOtherSourcePayId { get; set; }

    public Guid OtherSourcePayAttributeId { get; set; }

    public Guid BloodProductId { get; set; }

    public virtual CategoryBloodProduct BloodProduct { get; set; } = null!;

    public virtual CategoryAttribute OtherSourcePayAttribute { get; set; } = null!;
}
