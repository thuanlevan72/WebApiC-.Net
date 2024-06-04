using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục loại cấp cứu
/// </summary>
public partial class CategoryEmergencyType
{
    public Guid EmergencyTypeId { get; set; }

    public string EmergencyTypeCode { get; set; } = null!;

    public string EmergencyTypeName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<PatientEmergency> PatientEmergencies { get; set; } = new List<PatientEmergency>();
}
