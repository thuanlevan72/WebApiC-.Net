using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ ngoài điều trị - Nhóm chi phí
/// </summary>
public partial class OutsiteOfTreatmentServiceTabCostGroup
{
    public Guid OutSiteOfTreatmentServiceTabCostGroupId { get; set; }

    public Guid OutSiteOfTreatmentServiceId { get; set; }

    public Guid TabCostGroupId { get; set; }

    public virtual CategoryOutsiteOfTreatmentService OutSiteOfTreatmentService { get; set; } = null!;

    public virtual CategoryTabCostGroup TabCostGroup { get; set; } = null!;
}
