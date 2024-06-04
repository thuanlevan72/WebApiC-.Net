using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ giường - Tùy chọn giá
/// </summary>
public partial class BedServiceTabPriceOption
{
    public Guid BedServiceTabPriceOptionId { get; set; }

    public Guid BedServiceId { get; set; }

    public Guid TabPriceOptionId { get; set; }

    public virtual CategoryBedService BedService { get; set; } = null!;

    public virtual CategoryTabPriceOption TabPriceOption { get; set; } = null!;
}
