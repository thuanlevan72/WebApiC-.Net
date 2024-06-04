using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh sách phiếu hoàn
/// </summary>
public partial class CategoryRefund
{
    public Guid RefundId { get; set; }

    public Guid PatientId { get; set; }

    /// <summary>
    /// dịch vụ hoàn trả
    /// </summary>
    public Guid DesignateServiceId { get; set; }

    /// <summary>
    /// mã phiếu hoàn : ngày hiện tại + stt hoàn format yyyyMMdd0000Index
    /// </summary>
    public string RefundCode { get; set; } = null!;

    /// <summary>
    /// lý do hoàn trả
    /// </summary>
    public Guid AdvanceForReasonId { get; set; }

    /// <summary>
    /// hình thức hoàn 1: trả dịch vụ
    /// </summary>
    public int RefundType { get; set; }

    /// <summary>
    /// phiếu thu
    /// </summary>
    public Guid ReceiptCodeId { get; set; }

    /// <summary>
    /// người yêu cầu
    /// </summary>
    public Guid AccountId { get; set; }

    /// <summary>
    /// thời gian yêu cầu
    /// </summary>
    public DateTime TimeRequest { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime DeletedAt { get; set; }

    /// <summary>
    /// trạng thái phiếu
    /// </summary>
    public int? IsStatus { get; set; }

    public virtual CategoryAccount Account { get; set; } = null!;

    public virtual CategoryReasonForAdvance AdvanceForReason { get; set; } = null!;

    public virtual CategoryPatient Patient { get; set; } = null!;
}
