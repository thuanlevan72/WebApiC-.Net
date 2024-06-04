using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chi tiết thấu - Khai báo cơ số
/// </summary>
public partial class BidDetailBaseDeclaration
{
    public Guid BidDetailBaseDeclarationId { get; set; }

    public Guid BidDetailId { get; set; }

    /// <summary>
    /// lý do : 1 điều chỉnh 2 vượt 20%
    /// </summary>
    public int Reason { get; set; }

    /// <summary>
    /// tình trạng 1: giảm 2 tăng
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// số lượng điều chỉnh
    /// </summary>
    public int? Qty { get; set; }

    /// <summary>
    /// ngày công văn/quyết định
    /// </summary>
    public DateTime DecisionDate { get; set; }

    public string UnitName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual CategoryBidDetail BidDetail { get; set; } = null!;
}
