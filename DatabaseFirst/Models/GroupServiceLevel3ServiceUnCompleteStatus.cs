using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Nhóm dịch vụ cấp 3 - Trạng thái không hoàn thành dv
/// </summary>
public partial class GroupServiceLevel3ServiceUnCompleteStatus
{
    public Guid GroupServiceLevel3ServiceUncompleteStatusId { get; set; }

    public Guid GroupServiceLevel3Id { get; set; }

    public Guid ServiceUncompleteStatusAttributeId { get; set; }

    public virtual CategoryGroupServiceLevel3 GroupServiceLevel3 { get; set; } = null!;

    public virtual CategoryAttribute ServiceUncompleteStatusAttribute { get; set; } = null!;
}
