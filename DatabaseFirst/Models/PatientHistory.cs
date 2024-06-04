using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Bệnh nhân- Lịch sử bệnh
/// </summary>
public partial class PatientHistory
{
    public Guid PatientHistoryId { get; set; }

    /// <summary>
    /// Quá trình bệnh lý
    /// </summary>
    public string? PathologicalProcess { get; set; }

    /// <summary>
    /// Tiền sử bệnh bản thân
    /// </summary>
    public string? Anamnesis { get; set; }

    /// <summary>
    /// tiền sử bệnh gia đình
    /// </summary>
    public string? AnamnesisFamily { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    /// <summary>
    /// dị ứng thuốc
    /// </summary>
    public string? DrugAllergy { get; set; }

    public virtual ICollection<CategoryBasicInformationPatient> CategoryBasicInformationPatients { get; set; } = new List<CategoryBasicInformationPatient>();
}
