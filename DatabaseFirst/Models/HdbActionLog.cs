using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class HdbActionLog
{
    public Guid Id { get; set; }

    public string? ActionName { get; set; }

    public string InputPayload { get; set; } = null!;

    public string RequestHeaders { get; set; } = null!;

    public string SessionVariables { get; set; } = null!;

    public string? ResponsePayload { get; set; }

    public string? Errors { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? ResponseReceivedAt { get; set; }

    public string Status { get; set; } = null!;
}
