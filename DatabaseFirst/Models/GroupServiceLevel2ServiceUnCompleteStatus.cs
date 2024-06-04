using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Nhóm dịch vụ cấp 2 - Trạng thái không hoàn thành dv
/// </summary>
public partial class GroupServiceLevel2ServiceUnCompleteStatus
{
    public Guid GroupServiceLevel2ServiceUncompletedStatusId { get; set; }

    public Guid GroupServiceLevel2Id { get; set; }

    public Guid ServiceUncompleteStatusAttributeId { get; set; }

    public virtual CategoryGroupServiceLevel2 GroupServiceLevel2 { get; set; } = null!;

    public virtual CategoryAttribute ServiceUncompleteStatusAttribute { get; set; } = null!;
}
