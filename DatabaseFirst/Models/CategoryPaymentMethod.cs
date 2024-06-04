using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục phương thức thanh toán
/// </summary>
public partial class CategoryPaymentMethod
{
    public Guid PaymentMethodId { get; set; }

    /// <summary>
    /// mã phương thức thanh toán
    /// </summary>
    public string PaymentMethodCode { get; set; } = null!;

    /// <summary>
    /// tên pttt
    /// </summary>
    public string PaymentMethodName { get; set; } = null!;

    /// <summary>
    /// đối tác
    /// </summary>
    public Guid? PartnerId { get; set; }

    /// <summary>
    /// mã hóa đơn
    /// </summary>
    public Guid? BillCodeAttributeId { get; set; }

    /// <summary>
    /// mức độ ưu tiên
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// loại pttt
    /// </summary>
    public Guid? PamentMethodTypeAttributeId { get; set; }

    /// <summary>
    /// loại đối tác
    /// </summary>
    public Guid? PartnerTypeAttributeId { get; set; }

    /// <summary>
    /// ncc khác bv
    /// </summary>
    public int IsDiffSupplies { get; set; }

    /// <summary>
    /// tiền mặt
    /// </summary>
    public int IsCash { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual CategoryAttribute? BillCodeAttribute { get; set; }

    public virtual ICollection<CategoryPatientDesignateService> CategoryPatientDesignateServices { get; set; } = new List<CategoryPatientDesignateService>();

    public virtual ICollection<ObjectTypePaymentMethod> ObjectTypePaymentMethods { get; set; } = new List<ObjectTypePaymentMethod>();

    public virtual CategoryAttribute? PamentMethodTypeAttribute { get; set; }

    public virtual CategoryPartner? Partner { get; set; }

    public virtual CategoryAttribute? PartnerTypeAttribute { get; set; }

    public virtual ICollection<PatientAdvanceReceipt> PatientAdvanceReceipts { get; set; } = new List<PatientAdvanceReceipt>();
}
