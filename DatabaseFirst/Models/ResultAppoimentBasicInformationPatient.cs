using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Kết luận khám - hẹn khám
/// </summary>
public partial class ResultAppoimentBasicInformationPatient
{
    public Guid ResultAppointmentBasicInfomationPatientId { get; set; }

    public Guid BasicInfomationPatientId { get; set; }

    public string PathologicalProcess { get; set; } = null!;

    public string? Note { get; set; }

    public string? Remind { get; set; }

    public DateTime AppointmentDate { get; set; }

    public Guid? RoomId { get; set; }

    public int? Result { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual CategoryBasicInformationPatient BasicInfomationPatient { get; set; } = null!;

    public virtual CategoryRoom? Room { get; set; }
}
