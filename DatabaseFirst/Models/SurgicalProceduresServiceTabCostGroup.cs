using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phẫu thuật thủ thuật - nhóm chi phí
/// </summary>
public partial class SurgicalProceduresServiceTabCostGroup
{
    public Guid SurgicalProceduresServiceTabCostGroupId { get; set; }

    public Guid? SurgicalProceduresServiceId { get; set; }

    public Guid TabCostGroupId { get; set; }

    public virtual CategorySurgicalProceduresService? SurgicalProceduresService { get; set; }

    public virtual CategoryTabCostGroup TabCostGroup { get; set; } = null!;
}
