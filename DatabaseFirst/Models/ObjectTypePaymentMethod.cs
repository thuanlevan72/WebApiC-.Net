using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Loại đối tượng - phương thức thanh toán
/// </summary>
public partial class ObjectTypePaymentMethod
{
    public Guid ObjectTypePaymentMethodId { get; set; }

    public Guid ObjectTypeId { get; set; }

    public Guid PaymentMethodId { get; set; }

    public decimal AdvanceThreshold { get; set; }

    public int IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategoryObjectType ObjectType { get; set; } = null!;

    public virtual CategoryPaymentMethod PaymentMethod { get; set; } = null!;
}
