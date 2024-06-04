using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phiếu sơ kết 15 ngày
/// </summary>
public partial class CategorySummary15Day
{
    public Guid Summary15DaysId { get; set; }

    public Guid DiagnoseNameId { get; set; }

    public string DiagnoseNameDetailId { get; set; } = null!;

    /// <summary>
    /// Diễn biến lâm sàng trong đợt điều trị
    /// </summary>
    public string ProcessTreatment { get; set; } = null!;

    /// <summary>
    /// Xét nghiệm cận lâm sàng
    /// </summary>
    public string LabClinical { get; set; } = null!;

    /// <summary>
    /// Quá trình điều trị
    /// </summary>
    public string InvestigationProcess { get; set; } = null!;

    /// <summary>
    /// Đánh giá kết quả
    /// </summary>
    public string ResultEvaluation { get; set; } = null!;

    /// <summary>
    /// Hướng điều trị và tiên lượng
    /// </summary>
    public string TreatmentDirection { get; set; } = null!;

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? DiagnoseNameText { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<CategorySummary15DayDiagnose> CategorySummary15DayDiagnoses { get; set; } = new List<CategorySummary15DayDiagnose>();

    public virtual CategoryDiseaseName DiagnoseName { get; set; } = null!;

    public virtual ICollection<SetupMedicalRecordSummary15Day> SetupMedicalRecordSummary15Days { get; set; } = new List<SetupMedicalRecordSummary15Day>();
}
