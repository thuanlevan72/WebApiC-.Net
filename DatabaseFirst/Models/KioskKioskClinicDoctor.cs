using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Kios-Màn hình bác sĩ
/// </summary>
public partial class KioskKioskClinicDoctor
{
    public Guid KioskKioskClinicDoctorId { get; set; }

    public Guid KioskId { get; set; }

    public Guid KioskClinicDoctorId { get; set; }

    public virtual CategoryKiosk Kiosk { get; set; } = null!;

    public virtual CategoryKioskClinicDoctor KioskClinicDoctor { get; set; } = null!;
}
