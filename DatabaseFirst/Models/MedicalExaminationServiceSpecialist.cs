using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Khám bệnh chuyên khoa
/// </summary>
public partial class MedicalExaminationServiceSpecialist
{
    public Guid MedicalExaminationServiceSpecialistId { get; set; }

    public Guid MedicalExaminationServiceId { get; set; }

    public Guid SpecialistId { get; set; }

    public virtual CategoryMedicalExaminationService MedicalExaminationService { get; set; } = null!;

    public virtual CategorySpecialist Specialist { get; set; } = null!;
}
