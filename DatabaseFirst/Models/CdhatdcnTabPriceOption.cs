using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// CDHATDCN - Tùy chọn giá
/// </summary>
public partial class CdhatdcnTabPriceOption
{
    public Guid CdhaTdcnTabPriceOptionId { get; set; }

    public Guid CdhaTdcnId { get; set; }

    public Guid TabPriceOptionId { get; set; }

    public virtual CategoryCdhatdcn CdhaTdcn { get; set; } = null!;

    public virtual CategoryTabPriceOption TabPriceOption { get; set; } = null!;
}
