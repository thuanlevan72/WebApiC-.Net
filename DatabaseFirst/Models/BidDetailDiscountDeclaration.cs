using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// chi tiết thầu - khai báo giảm giá
/// </summary>
public partial class BidDetailDiscountDeclaration
{
    public Guid BidDetailDiscountDeclarationId { get; set; }

    public Guid BidDetailId { get; set; }

    /// <summary>
    /// lý do
    /// </summary>
    public string Reason { get; set; } = null!;

    /// <summary>
    /// từ ngày
    /// </summary>
    public DateTime FromDate { get; set; }

    /// <summary>
    /// đến ngày
    /// </summary>
    public DateTime ToDate { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public decimal? PriceInsurance { get; set; }

    public decimal? PriceNoneInsurance { get; set; }

    public decimal? PriceVat { get; set; }

    public decimal? Surcharge { get; set; }

    public virtual CategoryBidDetail BidDetail { get; set; } = null!;
}
