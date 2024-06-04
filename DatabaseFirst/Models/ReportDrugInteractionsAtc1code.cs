using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// khai báo tương tác thuốc - mã atc
/// </summary>
public partial class ReportDrugInteractionsAtc1code
{
    public Guid ReportDrupInteractionAtc1CodeId { get; set; }

    public Guid ReportDrugInterationId { get; set; }

    public Guid AtcCodeId { get; set; }

    public virtual CategoryDrug AtcCode { get; set; } = null!;

    public virtual CategoryReportDrugInteraction ReportDrugInteration { get; set; } = null!;
}
