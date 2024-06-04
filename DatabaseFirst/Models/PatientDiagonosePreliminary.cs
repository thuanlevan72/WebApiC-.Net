using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chẩn đoán sơ bộ
/// </summary>
public partial class PatientDiagonosePreliminary
{
    public Guid PatientDiagnosePreliminaryId { get; set; }

    public Guid PreliminaryDiagnosisId { get; set; }

    public Guid PatientDiagnoseId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? Desc { get; set; }

    public virtual PatientDiagnose PatientDiagnose { get; set; } = null!;

    public virtual CategoryDiseaseName PreliminaryDiagnosis { get; set; } = null!;
}
