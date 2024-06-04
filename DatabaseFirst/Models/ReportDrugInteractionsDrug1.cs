using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Khai báo tương tác thuốc - biệt dược 1
/// </summary>
public partial class ReportDrugInteractionsDrug1
{
    public Guid ReportDrugInteractionDrug1Id { get; set; }

    public Guid ReportDrugInteractionId { get; set; }

    public Guid DrugId1 { get; set; }

    public virtual CategoryDrug DrugId1Navigation { get; set; } = null!;

    public virtual CategoryReportDrugInteraction ReportDrugInteraction { get; set; } = null!;
}
