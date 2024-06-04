using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Điều kiện thanh toán bảo hiểm- Đối tượng khám chữa bệnh
/// </summary>
public partial class TabInsurancePaymentConditionAttribute
{
    public Guid TabInsurancePaymentConditionAttributeId { get; set; }

    public Guid InsurancePaymentConditionId { get; set; }

    public Guid ObjectHealthcareAttributeId { get; set; }

    public virtual CategoryTabInsurancePaymentCondition InsurancePaymentCondition { get; set; } = null!;

    public virtual CategoryAttribute ObjectHealthcareAttribute { get; set; } = null!;
}
