using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Bộ chỉ định - Trường hợp kê dịch vụ
/// </summary>
public partial class DesignationKitServiceList
{
    public Guid DesigntionKitServiceListId { get; set; }

    public Guid DesignationKitId { get; set; }

    public Guid ServiceListAttributeId { get; set; }

    public virtual CategoryDesignationKit DesignationKit { get; set; } = null!;

    public virtual CategoryAttribute ServiceListAttribute { get; set; } = null!;
}
