using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class HdbCronEvent
{
    public string Id { get; set; } = null!;

    public string TriggerName { get; set; } = null!;

    public DateTime ScheduledTime { get; set; }

    public string Status { get; set; } = null!;

    public int Tries { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? NextRetryAt { get; set; }

    public virtual ICollection<HdbCronEventInvocationLog> HdbCronEventInvocationLogs { get; set; } = new List<HdbCronEventInvocationLog>();
}
