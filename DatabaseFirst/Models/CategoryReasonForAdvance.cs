using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục lý do tạm ứng
/// </summary>
public partial class CategoryReasonForAdvance
{
    public Guid ReasonForAdvanceId { get; set; }

    /// <summary>
    /// mã lý do tạm ứng
    /// </summary>
    public string ReasonForAdvanceCode { get; set; } = null!;

    public string ReasonForAdvanceName { get; set; } = null!;

    /// <summary>
    /// hoàn thanh toán
    /// </summary>
    public int IsPaymentRefund { get; set; }

    /// <summary>
    /// lý do hoàn
    /// </summary>
    public int IsCompletedReason { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryRefund> CategoryRefunds { get; set; } = new List<CategoryRefund>();

    public virtual ICollection<CdhatdcnlistChangeService> CdhatdcnlistChangeServices { get; set; } = new List<CdhatdcnlistChangeService>();

    public virtual ICollection<PatientAdvanceReceipt> PatientAdvanceReceipts { get; set; } = new List<PatientAdvanceReceipt>();
}
