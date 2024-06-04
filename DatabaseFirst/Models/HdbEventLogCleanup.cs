using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class HdbEventLogCleanup
{
    public string Id { get; set; } = null!;

    public string TriggerName { get; set; } = null!;

    public DateTime ScheduledAt { get; set; }

    public int? DeletedEventLogs { get; set; }

    public int? DeletedEventInvocationLogs { get; set; }

    public string Status { get; set; } = null!;
}
