using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Cơ chế duyệt/phát
/// </summary>
public partial class WarehouseMechanismBrowerPay
{
    public Guid WarehouseMechainsmBrowerPayId { get; set; }

    public Guid WarehouseId { get; set; }

    public Guid AttributeId { get; set; }

    public virtual CategoryAttribute Attribute { get; set; } = null!;

    public virtual CategoryWarehouse Warehouse { get; set; } = null!;
}
