using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Nhóm dịch vụ cấp 1 - Tạng thái không hoàn thành dịch vụ
/// </summary>
public partial class GroupServiceLevel1ServiceUnCompleteStatus
{
    public Guid GroupServiceLvl1ServiceUncompleteStatusId { get; set; }

    public Guid GroupServiceLevel1Id { get; set; }

    public Guid ServiceUncompleteStatusId { get; set; }

    public virtual CategoryGroupServiceLevel1 GroupServiceLevel1 { get; set; } = null!;

    public virtual CategoryAttribute ServiceUncompleteStatus { get; set; } = null!;
}
