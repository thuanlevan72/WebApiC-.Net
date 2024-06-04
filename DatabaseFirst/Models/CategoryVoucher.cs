using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ Vourcher
/// </summary>
public partial class CategoryVoucher
{
    public Guid VourcherId { get; set; }

    /// <summary>
    /// chương trình giảm giá
    /// </summary>
    public Guid ProgramId { get; set; }

    /// <summary>
    /// mã voucher
    /// </summary>
    public string VoucherCode { get; set; } = null!;

    /// <summary>
    /// số lượng voucher
    /// </summary>
    public int VoucherQty { get; set; }

    /// <summary>
    /// số lượng đã sử dụng
    /// </summary>
    public int? NumberOfUsed { get; set; }

    /// <summary>
    /// số lượng còn lại
    /// </summary>
    public int? NumberOfRemain { get; set; }

    /// <summary>
    /// mô tả
    /// </summary>
    public string VoucherDesc { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategoryProgram Program { get; set; } = null!;

    public virtual ICollection<ReceiptCodeDesignateServiceDiscount> ReceiptCodeDesignateServiceDiscounts { get; set; } = new List<ReceiptCodeDesignateServiceDiscount>();
}
