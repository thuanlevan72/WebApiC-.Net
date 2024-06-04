using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Nhập viện răng hàm mặt
/// </summary>
public partial class HopitalizeDentomaxillofacial
{
    public Guid HopitalizeDentomaxillofacialId { get; set; }

    public Guid HopitalizeId { get; set; }

    public string? Dentomaxillofacial { get; set; }

    public virtual Hospitalize Hopitalize { get; set; } = null!;
}
