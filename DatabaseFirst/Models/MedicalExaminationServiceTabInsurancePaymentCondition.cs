using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ khám bệnh - Đk thanh toán bảo hiểm
/// </summary>
public partial class MedicalExaminationServiceTabInsurancePaymentCondition
{
    public Guid MedicalExaminationServiceTabInsurancePaymentConditionId { get; set; }

    public Guid MedicalExaminationServiceId { get; set; }

    public Guid TabInsurancePaymentConditionId { get; set; }

    public virtual CategoryMedicalExaminationService MedicalExaminationService { get; set; } = null!;

    public virtual CategoryTabInsurancePaymentCondition TabInsurancePaymentCondition { get; set; } = null!;
}
