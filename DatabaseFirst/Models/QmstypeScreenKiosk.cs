using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Qms - màn hình kiosk
/// </summary>
public partial class QmstypeScreenKiosk
{
    public Guid QmsScreenKioskId { get; set; }

    public Guid QmsTypeId { get; set; }

    public Guid ScreenKioskId { get; set; }

    public virtual CategoryAttribute QmsType { get; set; } = null!;

    public virtual CategoryScreenKiosk ScreenKiosk { get; set; } = null!;
}
