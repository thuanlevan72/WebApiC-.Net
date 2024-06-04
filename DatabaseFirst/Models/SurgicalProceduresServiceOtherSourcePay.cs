using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phẫu thuật thủ thuật - nguồn chi trả khác
/// </summary>
public partial class SurgicalProceduresServiceOtherSourcePay
{
    public Guid SurgicalProceduresServiceOtherSourcePayId { get; set; }

    public Guid SurgicalProceduresServiceId { get; set; }

    public Guid OtherSourcePayId { get; set; }

    public virtual CategoryAttribute OtherSourcePay { get; set; } = null!;

    public virtual CategorySurgicalProceduresService SurgicalProceduresService { get; set; } = null!;
}
