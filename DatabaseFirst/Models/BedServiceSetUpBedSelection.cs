using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ giường - Thiết lập chọn giường
/// </summary>
public partial class BedServiceSetUpBedSelection
{
    public Guid BedServiceSetUpBedSelectionId { get; set; }

    public Guid BedServiceId { get; set; }

    public Guid SetUpBedSelectionId { get; set; }

    public virtual CategoryBedService BedService { get; set; } = null!;
}
