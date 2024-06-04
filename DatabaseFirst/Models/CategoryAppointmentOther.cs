using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh sách khách đặt lịch
/// </summary>
public partial class CategoryAppointmentOther
{
    public Guid AppointmentOtherId { get; set; }

    public string FullName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public DateTime DateAppointment { get; set; }

    public string Note { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? PatientId { get; set; }

    public virtual CategoryPatient? Patient { get; set; }
}
