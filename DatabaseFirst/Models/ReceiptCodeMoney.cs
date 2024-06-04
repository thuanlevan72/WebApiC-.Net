using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Lưu số tiền phiếu thu
/// </summary>
public partial class ReceiptCodeMoney
{
    public Guid ReceiptCodeMoneyId { get; set; }

    public Guid ReceiptCodeId { get; set; }

    /// <summary>
    /// tổng tiền bảo hiểm
    /// </summary>
    public double InsuranceTotal { get; set; }

    /// <summary>
    /// tổng tiền chính sách miễn giảm
    /// </summary>
    public double DiscountTotal { get; set; }

    /// <summary>
    /// tổng tiền nb thanh toán
    /// </summary>
    public double PatientTotal { get; set; }

    /// <summary>
    /// tiiền miễn giảm phiếu thu
    /// </summary>
    public double? DiscountReceiptCode { get; set; }

    public virtual CategoryPatientReceiptCode ReceiptCode { get; set; } = null!;
}
