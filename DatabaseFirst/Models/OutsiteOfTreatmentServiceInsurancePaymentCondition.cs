using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ ngoài điều trị - dk thanh toán bảo hiểm
/// </summary>
public partial class OutsiteOfTreatmentServiceInsurancePaymentCondition
{
    public Guid OutSiteOfTreatmentServiceInsurancePaymentConditionId { get; set; }

    public Guid OutSiteOfTreatmentServiceId { get; set; }

    public Guid TabInsurancePaymentConditionId { get; set; }

    public virtual CategoryOutsiteOfTreatmentService OutSiteOfTreatmentService { get; set; } = null!;

    public virtual CategoryTabInsurancePaymentCondition TabInsurancePaymentCondition { get; set; } = null!;
}
