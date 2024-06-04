using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ khám bệnh - dịch vụ kèm theo
/// </summary>
public partial class MedicalExaminationServiceTabAccompanyingService
{
    public Guid MedicalExaminationServiceTabAccompanyingServiceId { get; set; }

    public Guid MedicalExaminationServiceId { get; set; }

    public Guid TabAccompanyingServiceId { get; set; }

    public Guid? ProductId { get; set; }

    public virtual CategoryMedicalExaminationService MedicalExaminationService { get; set; } = null!;

    public virtual CategoryProduct? Product { get; set; }

    public virtual CategoryTabAccompanyingService TabAccompanyingService { get; set; } = null!;
}
