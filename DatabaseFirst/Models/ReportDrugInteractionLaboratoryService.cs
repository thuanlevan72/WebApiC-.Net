using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Khai báo tương tác thuốc - xét nghiệm
/// </summary>
public partial class ReportDrugInteractionLaboratoryService
{
    public Guid ReportDrugInterationLaboratoryServiceId { get; set; }

    public Guid ReportDrugInterationId { get; set; }

    public Guid LaboratoryServiceId { get; set; }

    public int LowIndex { get; set; }

    public int HighIndex { get; set; }

    public int ChildIndex { get; set; }

    public int ECrCl { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategoryLaboratoryService LaboratoryService { get; set; } = null!;

    public virtual CategoryReportDrugInteraction ReportDrugInteration { get; set; } = null!;
}
