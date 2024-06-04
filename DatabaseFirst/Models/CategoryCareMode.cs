using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chế độ chăm sóc
/// </summary>
public partial class CategoryCareMode
{
    public Guid CareModeId { get; set; }

    public string CareModeCode { get; set; } = null!;

    public string CareModeName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<PageTreatmentMedicalRecord> PageTreatmentMedicalRecords { get; set; } = new List<PageTreatmentMedicalRecord>();
}
