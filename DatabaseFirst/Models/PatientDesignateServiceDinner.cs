using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chỉ định suất ăn
/// </summary>
public partial class PatientDesignateServiceDinner
{
    public Guid PatientDesignateServiceDinnerId { get; set; }

    public Guid PatientDesignateServiceId { get; set; }

    /// <summary>
    /// số lượng
    /// </summary>
    public int Qty { get; set; }

    public int? Status { get; set; }

    /// <summary>
    /// mã phiếu lĩnh
    /// </summary>
    public Guid? ReceiptCodeId { get; set; }

    /// <summary>
    /// mã phiếu trả
    /// </summary>
    public Guid? ReceiptCode2Id { get; set; }

    public string? Note { get; set; }

    /// <summary>
    /// tự trả
    /// </summary>
    public int IsPayment { get; set; }

    /// <summary>
    /// không tính tiền
    /// </summary>
    public int IsNoCharge { get; set; }

    /// <summary>
    /// đột xuất
    /// </summary>
    public int IsUnexpected { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTimeOffset? DeletedAt { get; set; }

    public DateTime? TimeImplement { get; set; }

    public Guid? DinnerType { get; set; }

    public virtual CategoryAttribute? DinnerTypeNavigation { get; set; }

    public virtual ICollection<PageTreatmentPatientDesignateServiceDinner> PageTreatmentPatientDesignateServiceDinners { get; set; } = new List<PageTreatmentPatientDesignateServiceDinner>();

    public virtual CategoryPatientDesignateService PatientDesignateService { get; set; } = null!;

    public virtual CategoryReceiptCode? ReceiptCode { get; set; }

    public virtual CategoryReceiptCode? ReceiptCode2 { get; set; }
}
