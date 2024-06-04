using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Nhập viện -khoa mắt
/// </summary>
public partial class HospitalizeEye
{
    public Guid HospitalizeEyeId { get; set; }

    public Guid HospitalizeId { get; set; }

    /// <summary>
    /// thị lực không kính mắt phải
    /// </summary>
    public string? EyesightWithoutGlassesRightEye { get; set; }

    /// <summary>
    /// thị lực không kính mắt trái
    /// </summary>
    public string? EyesightWithoutGlassesLeftEye { get; set; }

    /// <summary>
    /// thị lực có kính mắt phải
    /// </summary>
    public string? EyesightGlassesRightEye { get; set; }

    /// <summary>
    /// thị lực có kính mắt trái
    /// </summary>
    public string? EyesightGlassesLeftEye { get; set; }

    /// <summary>
    /// nhãn áo mắt phải
    /// </summary>
    public string? EyeRightTension { get; set; }

    /// <summary>
    /// nhãn áp mắt trái
    /// </summary>
    public string? EyeLeftTension { get; set; }

    public virtual Hospitalize Hospitalize { get; set; } = null!;
}
