using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Bệnh nhân - Chẩn đoán
/// </summary>
public partial class PatientDiagnose
{
    public Guid PatientDiagnoseId { get; set; }

    /// <summary>
    /// Chẩn đoán bệnh
    /// </summary>
    public Guid? DiagnoseNameId { get; set; }

    /// <summary>
    /// chẩn đoán bệnh kèm theo
    /// </summary>
    public Guid? DiagnoseNameAccompanyingId { get; set; }

    /// <summary>
    /// chẩn đoán sơ bộ
    /// </summary>
    public string? PreliminaryDiagnosis { get; set; }

    /// <summary>
    /// mô tả chi tiết
    /// </summary>
    public string? DiagnosisDetail { get; set; }

    public int IsActive { get; set; }

    public Guid? DiagnoseTypeIcdId { get; set; }

    public string? Desc { get; set; }

    public virtual ICollection<CategoryBasicInformationPatient> CategoryBasicInformationPatients { get; set; } = new List<CategoryBasicInformationPatient>();

    public virtual CategoryDiseaseName? DiagnoseName { get; set; }

    public virtual CategoryDiseaseName? DiagnoseNameAccompanying { get; set; }

    public virtual CategoryDiseaseType? DiagnoseTypeIcd { get; set; }

    public virtual ICollection<PatientDiagnoseCompanying> PatientDiagnoseCompanyings { get; set; } = new List<PatientDiagnoseCompanying>();

    public virtual ICollection<PatientDiagonosePreliminary> PatientDiagonosePreliminaries { get; set; } = new List<PatientDiagonosePreliminary>();
}
