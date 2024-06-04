using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class HdbScheduledEventInvocationLog
{
    public string Id { get; set; } = null!;

    public string? EventId { get; set; }

    public int? Status { get; set; }

    public string? Request { get; set; }

    public string? Response { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual HdbScheduledEvent? Event { get; set; }
}
