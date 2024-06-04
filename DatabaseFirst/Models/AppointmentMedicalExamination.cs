using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Lịch hẹn - dịch vụ khám
/// </summary>
public partial class AppointmentMedicalExamination
{
    public Guid AppointmentMedicalExaminationId { get; set; }

    public Guid AppointmentId { get; set; }

    public Guid MedicalExaminationId { get; set; }

    public virtual CategoryAppoiment Appointment { get; set; } = null!;

    public virtual CategoryMedicalExaminationService MedicalExamination { get; set; } = null!;
}
