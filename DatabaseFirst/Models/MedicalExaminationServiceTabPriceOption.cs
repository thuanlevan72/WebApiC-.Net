using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ khám bệnh - Tùy chọn giá
/// </summary>
public partial class MedicalExaminationServiceTabPriceOption
{
    public Guid MedicalExaminationServiceTabPriceOptionId { get; set; }

    public Guid MedicalExaminationServiceId { get; set; }

    public Guid TabPriceOptionId { get; set; }

    public virtual CategoryMedicalExaminationService MedicalExaminationService { get; set; } = null!;

    public virtual CategoryTabPriceOption TabPriceOption { get; set; } = null!;
}
