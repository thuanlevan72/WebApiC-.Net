using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục sinh hiệu
/// </summary>
public partial class CategoryBiosignal
{
    public Guid BiosignalId { get; set; }

    public decimal? Circuit { get; set; }

    public decimal? BodyTemperature { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Spo2 { get; set; }

    public decimal? Height { get; set; }

    public decimal? BloodPressure { get; set; }

    public decimal? BloodPressure2 { get; set; }

    public decimal? Bmi { get; set; }

    public decimal? Breathing { get; set; }

    public Guid? BloodType { get; set; }

    public string? Physical { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid? PatientId { get; set; }

    public virtual CategoryAttribute? BloodTypeNavigation { get; set; }

    public virtual CategoryPatient? Patient { get; set; }
}
