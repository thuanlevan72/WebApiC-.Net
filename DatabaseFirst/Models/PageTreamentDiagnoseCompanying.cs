using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Tờ điều trị - chẩn đoán kèm theo
/// </summary>
public partial class PageTreamentDiagnoseCompanying
{
    public Guid PageTreatmentDiagnoseCompanyingId { get; set; }

    public Guid MedicalTreatmentPageTreatmentId { get; set; }

    public Guid DiagnoseId { get; set; }

    public string? DiagnoseText { get; set; }

    public virtual CategoryDiseaseName Diagnose { get; set; } = null!;

    public virtual PageTreatmentMedicalRecord MedicalTreatmentPageTreatment { get; set; } = null!;
}
