using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ xét nghiệm - nguồn chi trả khác
/// </summary>
public partial class LaboratoryServiceOtherSourcePay
{
    public Guid LaboratoryServiceOtherSourcePayId { get; set; }

    public Guid LaboratoryServiceId { get; set; }

    public Guid OtherSourcePayId { get; set; }

    public virtual CategoryLaboratoryService LaboratoryService { get; set; } = null!;

    public virtual CategoryAttribute OtherSourcePay { get; set; } = null!;
}
