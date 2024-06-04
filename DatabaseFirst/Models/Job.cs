using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class Job
{
    public Guid JobId { get; set; }

    public string? JobCode { get; set; }

    public string? JobTitle { get; set; }

    public string? IsActive { get; set; }
}
