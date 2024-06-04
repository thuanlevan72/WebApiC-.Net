using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Bệnh nhân - Khám xét
/// </summary>
public partial class PatientSearch
{
    public Guid PatientSearchId { get; set; }

    /// <summary>
    /// Toàn thân
    /// </summary>
    public string Body { get; set; } = null!;

    /// <summary>
    /// Bộ phận
    /// </summary>
    public string Parts { get; set; } = null!;

    /// <summary>
    /// lưu ý
    /// </summary>
    public string Note { get; set; } = null!;

    /// <summary>
    /// diến biến
    /// </summary>
    public string Process { get; set; } = null!;

    /// <summary>
    /// giai đoạn bệnh
    /// </summary>
    public string DiseaseStage { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryBasicInformationPatient> CategoryBasicInformationPatients { get; set; } = new List<CategoryBasicInformationPatient>();
}
