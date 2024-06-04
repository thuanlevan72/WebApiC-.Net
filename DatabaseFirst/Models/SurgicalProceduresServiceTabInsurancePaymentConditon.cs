using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phẫu thuật thủ thuật - đk thanh toán bh
/// </summary>
public partial class SurgicalProceduresServiceTabInsurancePaymentConditon
{
    public Guid SurgicalProceduresServiceTabInsurancePaymentConditionId { get; set; }

    public Guid SurgicalProcedureServiceId { get; set; }

    public Guid TabInsurancePaymentConditionId { get; set; }

    public virtual CategorySurgicalProceduresService SurgicalProcedureService { get; set; } = null!;

    public virtual CategoryTabInsurancePaymentCondition TabInsurancePaymentCondition { get; set; } = null!;
}
