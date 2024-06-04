using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// CDHATDCN - trường hợp kê dịch vụ
/// </summary>
public partial class CdhatdcnServiceList
{
    public Guid CdhaTdcnServiceListId { get; set; }

    public Guid CdhaTdcnId { get; set; }

    public Guid ServiceListId { get; set; }

    public virtual CategoryCdhatdcn CdhaTdcn { get; set; } = null!;

    public virtual CategoryAttribute ServiceList { get; set; } = null!;
}
