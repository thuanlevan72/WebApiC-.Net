using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// bộ chỉ định - dịch vụ trong bộ
/// </summary>
public partial class DesignationKitDesignationKitService
{
    public Guid DesignationKitDesignationKitServiceId { get; set; }

    public Guid DesignationKitId { get; set; }

    public Guid DesignationKitServiceId { get; set; }

    public virtual CategoryDesignationKit DesignationKit { get; set; } = null!;

    public virtual CategoryDesignationKitService DesignationKitService { get; set; } = null!;
}
