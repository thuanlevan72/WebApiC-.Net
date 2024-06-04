using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ giường - Nguồn chi trả khác
/// </summary>
public partial class BedServiceOtherSourcesPay
{
    public Guid BedSeriviceOtherSourcePayId { get; set; }

    public Guid BedServiceId { get; set; }

    public Guid OtherSourcePayId { get; set; }

    public virtual CategoryBedService BedService { get; set; } = null!;

    public virtual CategoryAttribute OtherSourcePay { get; set; } = null!;
}
