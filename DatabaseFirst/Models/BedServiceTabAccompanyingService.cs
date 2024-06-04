using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ giường - Dịch vụ kèm theo
/// </summary>
public partial class BedServiceTabAccompanyingService
{
    public Guid BedServiceTabAccompanyingServiceId { get; set; }

    public Guid BedServiceId { get; set; }

    public Guid TabAccompanyingServiceId { get; set; }

    public Guid? ProductId { get; set; }

    public virtual CategoryBedService BedService { get; set; } = null!;

    public virtual CategoryProduct? Product { get; set; }

    public virtual CategoryTabAccompanyingService TabAccompanyingService { get; set; } = null!;
}
