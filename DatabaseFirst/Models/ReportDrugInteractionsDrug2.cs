using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Khai báo tương tác thuốc 
/// </summary>
public partial class ReportDrugInteractionsDrug2
{
    public Guid ReportDrugInteractionDrug2 { get; set; }

    public Guid ReportDrugInteractionId { get; set; }

    public Guid DrugId { get; set; }

    public virtual CategoryDrug Drug { get; set; } = null!;

    public virtual CategoryReportDrugInteraction ReportDrugInteraction { get; set; } = null!;
}
