using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Loại đội tượng hàng đợi
/// </summary>
public partial class CategoryQueueObjectType
{
    public Guid QueueObjectTypeId { get; set; }

    public string QueueObjectTypeName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<SettingQueueQueueObjectType> SettingQueueQueueObjectTypes { get; set; } = new List<SettingQueueQueueObjectType>();
}
