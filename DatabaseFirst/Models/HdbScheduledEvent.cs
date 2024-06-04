using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class HdbScheduledEvent
{
    public string Id { get; set; } = null!;

    public string WebhookConf { get; set; } = null!;

    public DateTime ScheduledTime { get; set; }

    public string? RetryConf { get; set; }

    public string? Payload { get; set; }

    public string? HeaderConf { get; set; }

    public string Status { get; set; } = null!;

    public int Tries { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? NextRetryAt { get; set; }

    public string? Comment { get; set; }

    public virtual ICollection<HdbScheduledEventInvocationLog> HdbScheduledEventInvocationLogs { get; set; } = new List<HdbScheduledEventInvocationLog>();
}
