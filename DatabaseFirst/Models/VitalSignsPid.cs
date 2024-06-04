using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Nội trú sinh hiệu
/// </summary>
public partial class VitalSignsPid
{
    public Guid VitalSignsPidId { get; set; }

    public Guid BasicInformationPatientPid { get; set; }

    /// <summary>
    /// ngày tạo
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// mạch
    /// </summary>
    public string? Pulse { get; set; }

    /// <summary>
    /// huyết áp tâm thu
    /// </summary>
    public string? BloodPressure { get; set; }

    /// <summary>
    /// huyết áp tâm trương
    /// </summary>
    public string? BloodPressure2 { get; set; }

    /// <summary>
    /// nhịp thở
    /// </summary>
    public string? BreathingRate { get; set; }

    /// <summary>
    /// bóp bóng
    /// </summary>
    public int IsQueezeAmbuBall { get; set; }

    /// <summary>
    /// thở máy
    /// </summary>
    public int IsBreathingMachine { get; set; }

    public string? Weight { get; set; }

    public string? Temperature { get; set; }

    public Guid? AccountId { get; set; }

    public string? Data { get; set; }

    public virtual CategoryAccount? Account { get; set; }

    public virtual BasicInformationPatientIpd BasicInformationPatientP { get; set; } = null!;

    public virtual ICollection<VitalSignsPidSurvivalIndex> VitalSignsPidSurvivalIndices { get; set; } = new List<VitalSignsPidSurvivalIndex>();
}
