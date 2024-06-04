using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chẩn đoán kèm theo
/// </summary>
public partial class PatientDiagnoseCompanying
{
    public Guid PatientDiagnoseCompanyingId { get; set; }

    public Guid DiagnoseNameAccompanyingId { get; set; }

    public Guid PatientDiagnoseId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? Desc { get; set; }

    public virtual CategoryDiseaseName DiagnoseNameAccompanying { get; set; } = null!;

    public virtual PatientDiagnose PatientDiagnose { get; set; } = null!;
}
