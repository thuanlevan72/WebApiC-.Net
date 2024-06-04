using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class HdbVersion
{
    public Guid HasuraUuid { get; set; }

    public string Version { get; set; } = null!;

    public DateTime UpgradedOn { get; set; }

    public string CliState { get; set; } = null!;

    public string ConsoleState { get; set; } = null!;

    public string? EeClientId { get; set; }

    public string? EeClientSecret { get; set; }
}
