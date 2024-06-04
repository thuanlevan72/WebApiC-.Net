using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thiết lap vaccine
/// </summary>
public partial class SettingVaccine
{
    public Guid SettingVaccineId { get; set; }

    public Guid AccountDoctorId { get; set; }

    public Guid AccountNurseId { get; set; }

    public DateOnly CreatedAt { get; set; }

    public DateTimeOffset? FromTime { get; set; }

    public DateTimeOffset? ToTime { get; set; }

    public virtual CategoryAccount AccountDoctor { get; set; } = null!;

    public virtual CategoryAccount AccountNurse { get; set; } = null!;
}
