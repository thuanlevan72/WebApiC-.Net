using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Lý do đổi trả dv
/// </summary>
public partial class CategoryReasonServiceReturn
{
    public Guid ReasonServiceReturnId { get; set; }

    public string ReasonServiceReturnCode { get; set; } = null!;

    public string ReasonServiceReturnName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }
}
