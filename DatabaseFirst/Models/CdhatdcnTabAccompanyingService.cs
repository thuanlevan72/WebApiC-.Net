using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// CDHATDCN -  Dịch vụ kèm theo
/// </summary>
public partial class CdhatdcnTabAccompanyingService
{
    public Guid CdhaTdcnTabAccompanyingServiceId { get; set; }

    public Guid TabAccompanyingServiceId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid CdhaTdcnId { get; set; }

    public virtual CategoryCdhatdcn CdhaTdcn { get; set; } = null!;

    public virtual CategoryProduct? Product { get; set; }

    public virtual CategoryTabAccompanyingService TabAccompanyingService { get; set; } = null!;
}
