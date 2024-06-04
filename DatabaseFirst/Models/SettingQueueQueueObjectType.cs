using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thiết lập loại đối tượng
/// </summary>
public partial class SettingQueueQueueObjectType
{
    public Guid SettingQueueQueueObjectIdType { get; set; }

    public Guid QueueObjectTypeId { get; set; }

    public Guid SettingQueueId { get; set; }

    public int? Priority { get; set; }

    public int? IsSortQms { get; set; }

    public virtual CategoryQueueObjectType QueueObjectType { get; set; } = null!;

    public virtual CategoryQueue SettingQueue { get; set; } = null!;
}
