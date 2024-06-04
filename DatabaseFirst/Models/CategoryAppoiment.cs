using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Lịch hẹn
/// </summary>
public partial class CategoryAppoiment
{
    public Guid AppointmentId { get; set; }

    public Guid PatientId { get; set; }

    public Guid AppointmentType { get; set; }

    public DateTime AppointmentDate { get; set; }

    public string Note { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime DeletedAt { get; set; }

    public Guid CreatedBy { get; set; }

    public Guid ChangedBy { get; set; }

    public virtual ICollection<AppointmentMedicalExamination> AppointmentMedicalExaminations { get; set; } = new List<AppointmentMedicalExamination>();

    public virtual CategoryAttribute AppointmentTypeNavigation { get; set; } = null!;

    public virtual CategoryPatient Patient { get; set; } = null!;
}
