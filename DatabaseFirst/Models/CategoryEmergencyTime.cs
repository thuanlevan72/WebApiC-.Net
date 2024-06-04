using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thời gian cấp cứu
/// </summary>
public partial class CategoryEmergencyTime
{
    public Guid EmergencyTimeId { get; set; }

    public string EmergencyTimeCode { get; set; } = null!;

    public string EmergencyTimeName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<PatientEmergency> PatientEmergencies { get; set; } = new List<PatientEmergency>();
}
