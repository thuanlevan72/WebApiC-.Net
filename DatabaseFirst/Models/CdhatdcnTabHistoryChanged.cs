using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// CDHATDCN - Lịch sử chỉnh sửa
/// </summary>
public partial class CdhatdcnTabHistoryChanged
{
    public Guid CdhaTdcnTabHistoryChangedId { get; set; }

    public Guid CdhaTdcnId { get; set; }

    public Guid TabHistoryChangedId { get; set; }

    public virtual CategoryCdhatdcn CdhaTdcn { get; set; } = null!;

    public virtual CategoryTabHistoryChanged TabHistoryChanged { get; set; } = null!;
}
