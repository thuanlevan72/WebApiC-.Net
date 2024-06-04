using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục loại thanh toán
/// </summary>
public partial class CategoryPaymentType
{
    public Guid PaymentTypeId { get; set; }

    /// <summary>
    /// mã loại thanh toán
    /// </summary>
    public string PaymentTypeCode { get; set; } = null!;

    /// <summary>
    /// tên loại thanh toán
    /// </summary>
    public string PaymentTypeName { get; set; } = null!;

    /// <summary>
    /// quyển số thu
    /// </summary>
    public Guid? BookReceipt { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangeBy { get; set; }

    public virtual CategoryAttribute? BookReceiptNavigation { get; set; }

    public virtual ICollection<CategoryTabPriceOption> CategoryTabPriceOptions { get; set; } = new List<CategoryTabPriceOption>();

    public virtual ICollection<ObjectTypePaymentType> ObjectTypePaymentTypes { get; set; } = new List<ObjectTypePaymentType>();
}
