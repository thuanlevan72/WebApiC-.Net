using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Khai báo tương tác thuốc - chẩn đoán bệnh
/// </summary>
public partial class ReportDrugInteractionsDiseaseName
{
    public Guid ReportDrugInteractionDiseaseNameId { get; set; }

    public Guid ReportDrugInteractionId { get; set; }

    public Guid DiseaseNameId { get; set; }

    public virtual CategoryDiseaseName DiseaseName { get; set; } = null!;

    public virtual CategoryReportDrugInteraction ReportDrugInteraction { get; set; } = null!;
}
