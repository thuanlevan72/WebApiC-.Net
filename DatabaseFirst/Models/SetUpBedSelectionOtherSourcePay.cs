using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thiết lập chọn giường - nguồn chi trả khác
/// </summary>
public partial class SetUpBedSelectionOtherSourcePay
{
    public Guid SetUpBedSelectionOtherSourcePayId { get; set; }

    public Guid SetUpBedSelectionId { get; set; }

    public Guid OtherSourcePayId { get; set; }

    public virtual CategoryAttribute OtherSourcePay { get; set; } = null!;
}
