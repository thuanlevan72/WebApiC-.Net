using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục màn hình kiosk
/// </summary>
public partial class CategoryScreenKiosk
{
    public Guid ScreenKioskId { get; set; }

    public string ScreenKioskName { get; set; } = null!;

    public int? IsOrder { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<KioskScreenKiosk> KioskScreenKiosks { get; set; } = new List<KioskScreenKiosk>();

    public virtual ICollection<QmstypeScreenKiosk> QmstypeScreenKiosks { get; set; } = new List<QmstypeScreenKiosk>();
}
