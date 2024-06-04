using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// CDHATDCN- Nguồn chi trả khác
/// </summary>
public partial class CdhatdcnOtherSourcePay
{
    public Guid CdhaTdcnOtherSourcePayId { get; set; }

    public Guid CdhaTdcnId { get; set; }

    public Guid OtherSourcePayId { get; set; }

    public virtual CategoryCdhatdcn CdhaTdcn { get; set; } = null!;

    public virtual CategoryAttribute OtherSourcePay { get; set; } = null!;
}
