using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Báo cáo - Loại phiếu
/// </summary>
public partial class ReportBallotType
{
    public Guid ReportBallotTypeId { get; set; }

    public Guid ReportId { get; set; }

    public Guid BallotTypeId { get; set; }

    public virtual CategoryBallotType BallotType { get; set; } = null!;

    public virtual CategoryReport Report { get; set; } = null!;
}
