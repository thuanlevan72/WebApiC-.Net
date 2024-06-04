using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// bệnh nhân - Phiếu thu tạm ứng
/// </summary>
public partial class PatientAdvanceReceipt
{
    public Guid PatientAdvanceReceiptId { get; set; }

    /// <summary>
    /// thông tin bệnh nhân
    /// </summary>
    public Guid PatientId { get; set; }

    /// <summary>
    /// số tiền tạm ứng
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// phương thức thanh toán
    /// </summary>
    public Guid? PaymentMethodId { get; set; }

    /// <summary>
    /// lý do tạm ứng
    /// </summary>
    public Guid ReasonForAdvanceId { get; set; }

    public string? Note { get; set; }

    /// <summary>
    /// 0: đề nghị 1: đã tạm ứng 2 hoàn tạm ứng 3 hủy tạm ứng
    /// </summary>
    public int IsStatus { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public decimal? PriceRemain { get; set; }

    /// <summary>
    /// khoa
    /// </summary>
    public Guid? DepartmentId { get; set; }

    /// <summary>
    /// trạng thái khoa
    /// </summary>
    public int? DepartmentStatus { get; set; }

    /// <summary>
    /// mã phiếu
    /// </summary>
    public string? AdvanceReceiptCode { get; set; }

    /// <summary>
    /// 0: chưa duyệt 1 duyệt
    /// </summary>
    public int? IsConfirm { get; set; }

    public string? AdvanceReceiptSymbol { get; set; }

    /// <summary>
    /// loại đối tượng
    /// </summary>
    public Guid? ObjectTypeId { get; set; }

    /// <summary>
    /// số lần tạm ứng của bệnh nhân
    /// </summary>
    public int? Times { get; set; }

    /// <summary>
    /// quầy
    /// </summary>
    public Guid? CounterId { get; set; }

    /// <summary>
    /// ca làm việc
    /// </summary>
    public Guid? ShiftId { get; set; }

    /// <summary>
    /// thu ngân
    /// </summary>
    public Guid? CreatedBy { get; set; }

    public virtual CategoryCounter? Counter { get; set; }

    public virtual CategoryAccount? CreatedByNavigation { get; set; }

    public virtual CategoryObjectType? ObjectType { get; set; }

    public virtual CategoryPatient Patient { get; set; } = null!;

    public virtual CategoryPaymentMethod? PaymentMethod { get; set; }

    public virtual CategoryReasonForAdvance ReasonForAdvance { get; set; } = null!;

    public virtual CategoryShift? Shift { get; set; }
}
