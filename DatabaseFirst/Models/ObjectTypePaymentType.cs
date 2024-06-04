using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Loại đối tượng - loại hình thanh toán
/// </summary>
public partial class ObjectTypePaymentType
{
    public Guid ObjectTypePaymentTypeId { get; set; }

    public Guid ObjectTypeId { get; set; }

    public Guid PaymentTypeId { get; set; }

    public int? Priority { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual CategoryObjectType ObjectType { get; set; } = null!;

    public virtual CategoryPaymentType PaymentType { get; set; } = null!;
}
