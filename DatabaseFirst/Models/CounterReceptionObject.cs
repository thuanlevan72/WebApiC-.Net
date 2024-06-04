using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Quầy - Đối tượng tiếp đón
/// </summary>
public partial class CounterReceptionObject
{
    public Guid CounterReceptionObjectId { get; set; }

    public Guid CounterId { get; set; }

    /// <summary>
    /// không bảo hiểm
    /// </summary>
    public int IsNonInsurance { get; set; }

    /// <summary>
    /// bảo hiểm
    /// </summary>
    public int IsInsurance { get; set; }

    /// <summary>
    /// ưu tiên
    /// </summary>
    public int IsPriority { get; set; }

    /// <summary>
    /// mức độ ưu tiên không bảo hiểm
    /// </summary>
    public int? PriorityNonInsurance { get; set; }

    /// <summary>
    /// mức độ ưu tiên bảo hiểm
    /// </summary>
    public int? PriorityInsurance { get; set; }

    /// <summary>
    /// mức độ ưu tiên ưu tiên
    /// </summary>
    public int? PriorityPriorty { get; set; }

    public virtual CategoryCounter Counter { get; set; } = null!;
}
