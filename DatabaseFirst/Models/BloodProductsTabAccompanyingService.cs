using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chế phẩm máu - Dịch vụ kèm theo
/// </summary>
public partial class BloodProductsTabAccompanyingService
{
    public Guid BloodProductAccompanyingServiceId { get; set; }

    public Guid BloodProductId { get; set; }

    public Guid TabAccompanyingServiceId { get; set; }

    public Guid? ProductId { get; set; }

    public virtual CategoryBloodProduct BloodProduct { get; set; } = null!;

    public virtual CategoryProduct? Product { get; set; }

    public virtual CategoryTabAccompanyingService TabAccompanyingService { get; set; } = null!;
}
