using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// kiosk - màn hình kiosk
/// </summary>
public partial class KioskScreenKiosk
{
    public Guid KioskScreenKioskId { get; set; }

    public Guid KioskId { get; set; }

    public Guid ScreenKioskId { get; set; }

    public int? IsActive { get; set; }

    public virtual CategoryKiosk Kiosk { get; set; } = null!;

    public virtual CategoryScreenKiosk ScreenKiosk { get; set; } = null!;
}
