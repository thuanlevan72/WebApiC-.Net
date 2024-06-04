using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Hội đồng - chi tiết hội đồng
/// </summary>
public partial class CouncilDetailCouncil
{
    public Guid CouncilDetailCouncilId { get; set; }

    public Guid CouncilId { get; set; }

    public Guid CouncilDetailId { get; set; }

    public virtual CategoryCouncil Council { get; set; } = null!;

    public virtual CategoryCouncilDetail CouncilDetail { get; set; } = null!;
}
