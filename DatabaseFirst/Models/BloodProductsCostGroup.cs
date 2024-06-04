using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục Chế phẩm máu - Nhóm chi phí
/// </summary>
public partial class BloodProductsCostGroup
{
    public Guid BloodProductCostGroupId { get; set; }

    public Guid BloodProductId { get; set; }

    public Guid TabCostGroupId { get; set; }

    public virtual CategoryBloodProduct BloodProduct { get; set; } = null!;

    public virtual CategoryTabCostGroup TabCostGroup { get; set; } = null!;
}
