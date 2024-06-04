using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Hẹn lịch điều trị
/// </summary>
public partial class PatientAppointment
{
    public Guid PatientAppoinmentId { get; set; }

    public Guid PatientReceptionId { get; set; }

    public Guid AppoimentType { get; set; }

    public DateTime AppoimentDate { get; set; }

    public string? Note { get; set; }

    public Guid? AccountId { get; set; }

    public int? IsActive { get; set; }

    public int? IsStatus { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? PatientDesignateServiceId { get; set; }

    public virtual CategoryAttribute AppoimentTypeNavigation { get; set; } = null!;

    public virtual ICollection<PatientAppointmentService> PatientAppointmentServices { get; set; } = new List<PatientAppointmentService>();

    public virtual CategoryPatientDesignateService? PatientDesignateService { get; set; }

    public virtual CategoryPatientReception PatientReception { get; set; } = null!;
}
