using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// nhập viện - Tai mũi họng
/// </summary>
public partial class HospitalizeOtorhinolaryngology
{
    public Guid HospitalizeOtorhinolaryngologyId { get; set; }

    public Guid HopitalizeId { get; set; }

    public string? Ears { get; set; }

    public string? Nose { get; set; }

    public string? Throat { get; set; }

    public virtual Hospitalize Hopitalize { get; set; } = null!;
}
