using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phục hồi chức năng - đk thanh toán bh
/// </summary>
public partial class RehabilitationServiceTabInsurancePaymentConditon
{
    public Guid RehabilitationServiceTabInsurancePaymentConditionId { get; set; }

    public Guid RehabilitationServiceId { get; set; }

    public Guid TabInsurancePaymentConditionId { get; set; }

    public virtual CategoryRehabilitationsService RehabilitationService { get; set; } = null!;

    public virtual CategoryTabInsurancePaymentCondition TabInsurancePaymentCondition { get; set; } = null!;
}
