using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Hồ sơ bệnh án và sơ kết 15 ngày
/// </summary>
public partial class SetupMedicalRecordSummary15Day
{
    public Guid SetupMedicalRecordSummary15DayId { get; set; }

    public Guid SetupMedicalRecordId { get; set; }

    public Guid Summary15DayId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual CategorySetupMedicalRecord SetupMedicalRecord { get; set; } = null!;

    public virtual CategorySummary15Day Summary15Day { get; set; } = null!;
}
