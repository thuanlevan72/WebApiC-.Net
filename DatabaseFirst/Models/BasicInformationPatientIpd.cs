using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Bệnh nhân nội trú
/// </summary>
public partial class BasicInformationPatientIpd
{
    public Guid BasicInformationPatientPid { get; set; }

    public Guid PatientId { get; set; }

    /// <summary>
    /// khoa
    /// </summary>
    public Guid DepartmentId { get; set; }

    /// <summary>
    /// chẩn đoán vào viện
    /// </summary>
    public Guid DiagnosticId { get; set; }

    /// <summary>
    /// cân nặng
    /// </summary>
    public int? Weight { get; set; }

    /// <summary>
    /// nhóm máu
    /// </summary>
    public Guid? BloodType { get; set; }

    /// <summary>
    /// bác sĩ chỉ định
    /// </summary>
    public Guid? EmployeeId { get; set; }

    /// <summary>
    /// lý do vào nội trú
    /// </summary>
    public string? Reason { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? IsStatus { get; set; }

    public Guid? BasicInformationPatientId { get; set; }

    /// <summary>
    /// bác sĩ điều trị
    /// </summary>
    public Guid? AccountTreatmentId { get; set; }

    /// <summary>
    /// ghi chú
    /// </summary>
    public string? Note { get; set; }

    public string? DiagnoseNameText { get; set; }

    public virtual CategoryAccount? AccountTreatment { get; set; }

    public virtual CategoryBasicInformationPatient? BasicInformationPatient { get; set; }

    public virtual CategoryAttribute? BloodTypeNavigation { get; set; }

    public virtual ICollection<CategorySetupMedicalRecord> CategorySetupMedicalRecords { get; set; } = new List<CategorySetupMedicalRecord>();

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual ICollection<DesignateServicePrescriptionIpd> DesignateServicePrescriptionIpds { get; set; } = new List<DesignateServicePrescriptionIpd>();

    public virtual CategoryDiseaseName Diagnostic { get; set; } = null!;

    public virtual CategoryEmployee? Employee { get; set; }

    public virtual CategoryPatient Patient { get; set; } = null!;

    public virtual ICollection<VitalSignsPid> VitalSignsPids { get; set; } = new List<VitalSignsPid>();
}
