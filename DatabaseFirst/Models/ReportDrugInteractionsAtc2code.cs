using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// khai báo tương tác thuốc - mã atc 2
/// </summary>
public partial class ReportDrugInteractionsAtc2code
{
    public Guid ReportDrugInteractionAtc2CodeId { get; set; }

    public Guid ReportDrugInteractionId { get; set; }

    public Guid Atc2CodeId { get; set; }

    public virtual CategoryDrug Atc2Code { get; set; } = null!;

    public virtual CategoryReportDrugInteraction ReportDrugInteraction { get; set; } = null!;
}
