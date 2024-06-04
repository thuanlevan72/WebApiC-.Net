using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class EventInvocationLog
{
    public string Id { get; set; } = null!;

    public string? TriggerName { get; set; }

    public string? EventId { get; set; }

    public int? Status { get; set; }

    public string? Request { get; set; }

    public string? Response { get; set; }

    public DateTime? CreatedAt { get; set; }
}
