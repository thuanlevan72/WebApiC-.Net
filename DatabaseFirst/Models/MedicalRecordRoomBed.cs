using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Nội trú - Phòng giường
/// </summary>
public partial class MedicalRecordRoomBed
{
    public Guid MedicalRecordRoomBedId { get; set; }

    public Guid SetupMedicalRecordId { get; set; }

    public Guid? RoomId { get; set; }

    public Guid BedNumberId { get; set; }

    public Guid DepartmentId { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public double BedNumber { get; set; }

    public int Type { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime DeletedAt { get; set; }

    public virtual CategoryBedNumber BedNumberNavigation { get; set; } = null!;

    public virtual CategoryRoom? Room { get; set; }

    public virtual CategorySetupMedicalRecord SetupMedicalRecord { get; set; } = null!;
}
