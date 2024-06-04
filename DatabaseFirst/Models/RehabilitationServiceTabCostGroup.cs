using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class RehabilitationServiceTabCostGroup
{
    public Guid RehabilitationServiceTabCostGroupId { get; set; }

    public Guid RehabilitationServiceId { get; set; }

    public Guid TabCostGroupId { get; set; }

    public virtual CategoryRehabilitationsService RehabilitationService { get; set; } = null!;

    public virtual CategoryTabCostGroup TabCostGroup { get; set; } = null!;
}
