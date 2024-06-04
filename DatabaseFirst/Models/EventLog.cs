using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class EventLog
{
    public string Id { get; set; } = null!;

    public string SchemaName { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public string TriggerName { get; set; } = null!;

    public string Payload { get; set; } = null!;

    public bool Delivered { get; set; }

    public bool Error { get; set; }

    public int Tries { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? Locked { get; set; }

    public DateTime? NextRetryAt { get; set; }

    public bool Archived { get; set; }
}
