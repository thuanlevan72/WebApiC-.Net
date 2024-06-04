using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thiết lập hàng đợi
/// </summary>
public partial class CategoryQueue
{
    public Guid QueueId { get; set; }

    public Guid RoomType { get; set; }

    public Guid? QmsType { get; set; }

    public int MaxPatient { get; set; }

    public int MinPatient { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategoryAttribute? QmsTypeNavigation { get; set; }

    public virtual CategoryAttribute RoomTypeNavigation { get; set; } = null!;

    public virtual ICollection<SettingQueueQueueObjectType> SettingQueueQueueObjectTypes { get; set; } = new List<SettingQueueQueueObjectType>();
}
