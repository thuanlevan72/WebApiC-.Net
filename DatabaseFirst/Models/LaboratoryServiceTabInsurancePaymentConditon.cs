using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Xét nghiệm - điều kiện thanh toán bh
/// </summary>
public partial class LaboratoryServiceTabInsurancePaymentConditon
{
    public Guid LaboratoryServiceTabInsurancePaymentConditionId { get; set; }

    public Guid LaboratoryServiceId { get; set; }

    public Guid TabInsurancePaymentConditionId { get; set; }

    public virtual CategoryLaboratoryService LaboratoryService { get; set; } = null!;

    public virtual CategoryTabInsurancePaymentCondition TabInsurancePaymentCondition { get; set; } = null!;
}
