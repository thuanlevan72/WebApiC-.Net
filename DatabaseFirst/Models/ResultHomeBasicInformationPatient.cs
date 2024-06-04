using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Kết luận khám -cho về
/// </summary>
public partial class ResultHomeBasicInformationPatient
{
    public Guid ResultBasicInfomatiionPatientId { get; set; }

    public int TreatmentDirection { get; set; }

    public int Result { get; set; }

    public Guid BasicInformationPatientId { get; set; }

    public string? Remind { get; set; }

    public virtual CategoryBasicInformationPatient BasicInformationPatient { get; set; } = null!;
}
