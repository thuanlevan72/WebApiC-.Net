using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phiếu thu - Giảm giá
/// </summary>
public partial class ReceiptCodeDesignateServiceDiscount
{
    public Guid ReceiptCodeDesignateServiceDiscountId { get; set; }

    public Guid? ReceiptCodeDesignateServiceId { get; set; }

    public int? DiscountType { get; set; }

    public decimal? DiscountPercent { get; set; }

    public decimal? DiscountMoney { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? Note { get; set; }

    public Guid? VoucherId { get; set; }

    public Guid? PatientDesignateServiceId { get; set; }

    public virtual ICollection<DesignateServiceDiscountHistory> DesignateServiceDiscountHistories { get; set; } = new List<DesignateServiceDiscountHistory>();

    public virtual CategoryPatientDesignateService? PatientDesignateService { get; set; }

    public virtual ReceiptCodeDesignateService? ReceiptCodeDesignateService { get; set; }

    public virtual CategoryVoucher? Voucher { get; set; }
}
