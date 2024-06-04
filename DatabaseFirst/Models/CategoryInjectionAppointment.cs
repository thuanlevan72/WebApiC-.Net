using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Hẹn tiêm
/// </summary>
public partial class CategoryInjectionAppointment
{
    public Guid InjectionAppointmentId { get; set; }

    /// <summary>
    /// mũi tiêm
    /// </summary>
    public int QtyInjections { get; set; }

    /// <summary>
    /// liều lượng
    /// </summary>
    public string Amount { get; set; } = null!;

    public Guid VaccineId { get; set; }

    /// <summary>
    /// ngày hẹn
    /// </summary>
    public DateTime? InjectionsDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? Note { get; set; }

    public Guid? PatientId { get; set; }

    /// <summary>
    /// 0: tạo mới, 1: đã nhắc lịch, 2: đã tiếp đón, 3: huỷ lịch
    /// </summary>
    public int? Status { get; set; }

    public Guid? PatientReceptionId { get; set; }

    public virtual CategoryPatient? Patient { get; set; }

    public virtual CategoryPatientReception? PatientReception { get; set; }

    public virtual CategoryVaccine Vaccine { get; set; } = null!;
}
