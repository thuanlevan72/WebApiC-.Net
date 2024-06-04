using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh sách điều trị dài hạn
/// </summary>
public partial class CategoryLongTermTreatment
{
    public Guid LongTermTreatmentId { get; set; }

    public Guid? BasicInformationPatientId { get; set; }

    public Guid? PatientId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? SetupMedicalRecordId { get; set; }

    /// <summary>
    /// thông tin kết thúc bệnh án
    /// </summary>
    public string? Data { get; set; }

    /// <summary>
    /// thời gian kết thúc
    /// </summary>
    public DateTime? FinishTime { get; set; }

    /// <summary>
    /// kết thúc điều trị
    /// </summary>
    public int? TreatmentResult { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual CategoryBasicInformationPatient? BasicInformationPatient { get; set; }

    public virtual CategoryPatient? Patient { get; set; }

    public virtual CategorySetupMedicalRecord? SetupMedicalRecord { get; set; }
}
