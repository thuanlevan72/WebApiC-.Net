using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thuốc - nguồn chi trả khác
/// </summary>
public partial class DrugOtherSourcesPay
{
    public Guid DrugOtherSourcePayId { get; set; }

    public Guid DrugId { get; set; }

    public Guid OtherSourcePayAttributeId { get; set; }

    public virtual CategoryDrug Drug { get; set; } = null!;

    public virtual CategoryAttribute OtherSourcePayAttribute { get; set; } = null!;
}
