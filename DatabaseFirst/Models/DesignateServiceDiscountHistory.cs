using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Lịch sử giảm giá
/// </summary>
public partial class DesignateServiceDiscountHistory
{
    public Guid DesignateServiceDiscountHistoryId { get; set; }

    public Guid ReceiptCodeDesignateServiceDiscountId { get; set; }

    public int QtyOld { get; set; }

    public int QtyNew { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ReceiptCodeDesignateServiceDiscount ReceiptCodeDesignateServiceDiscount { get; set; } = null!;
}
