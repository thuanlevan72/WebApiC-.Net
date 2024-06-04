using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ khám bệnh - Nguồn khác chi trả
/// </summary>
public partial class MedicalExaminationServiceOtherSourcePay
{
    public Guid MedicalExaminationServiceOtherSourcePayId { get; set; }

    public Guid MedicalExaminationServiceId { get; set; }

    public Guid OtherSourcePayId { get; set; }

    public virtual CategoryMedicalExaminationService MedicalExaminationService { get; set; } = null!;

    public virtual CategoryAttribute OtherSourcePay { get; set; } = null!;
}
