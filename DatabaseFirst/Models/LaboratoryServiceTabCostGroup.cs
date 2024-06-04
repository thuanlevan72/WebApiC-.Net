using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// xét nghiệm - nhóm chi phí
/// </summary>
public partial class LaboratoryServiceTabCostGroup
{
    public Guid LaboratoryServiceTabCostGroupId { get; set; }

    public Guid LaboratoryServiceId { get; set; }

    public Guid TabCostGroupId { get; set; }

    public virtual CategoryLaboratoryService LaboratoryService { get; set; } = null!;

    public virtual CategoryTabCostGroup TabCostGroup { get; set; } = null!;
}
