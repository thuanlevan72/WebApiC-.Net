using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ giường - trường hợp kê dịch vụ
/// </summary>
public partial class BedServiceServiceList
{
    public Guid BedServiceServiceListId { get; set; }

    public Guid BedServiceId { get; set; }

    public Guid ServiceListId { get; set; }

    public virtual CategoryBedService BedService { get; set; } = null!;

    public virtual CategoryAttribute ServiceList { get; set; } = null!;
}
