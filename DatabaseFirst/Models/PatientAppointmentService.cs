using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Lịch hẹn -dịch vụ
/// </summary>
public partial class PatientAppointmentService
{
    public Guid PatientAppoimentServiceId { get; set; }

    public Guid PatientAppoinmentId { get; set; }

    public Guid ProductId { get; set; }

    public virtual PatientAppointment PatientAppoinment { get; set; } = null!;

    public virtual CategoryProduct Product { get; set; } = null!;
}
