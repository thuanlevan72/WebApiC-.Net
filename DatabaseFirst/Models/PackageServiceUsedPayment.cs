using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thanh toán gói
/// </summary>
public partial class PackageServiceUsedPayment
{
    public Guid PackageServiceUserPaymentId { get; set; }

    public Guid PackageServiceId { get; set; }

    /// <summary>
    /// tổng tiền
    /// </summary>
    public decimal Total { get; set; }

    /// <summary>
    /// số phiếu đối ứng
    /// </summary>
    public string PackageReceiptCode { get; set; } = null!;

    /// <summary>
    /// ký hiệu
    /// </summary>
    public string PackageReceiptSymbol { get; set; } = null!;

    public int IsStatus { get; set; }

    /// <summary>
    /// lý do
    /// </summary>
    public string Reason { get; set; } = null!;

    public Guid? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    /// <summary>
    /// ghi chú
    /// </summary>
    public int? Note { get; set; }

    public Guid? PatientPackageServiceId { get; set; }

    public string? CodeBase { get; set; }

    public virtual CategoryPackageService PackageService { get; set; } = null!;

    public virtual PatientPackageService? PatientPackageService { get; set; }
}
