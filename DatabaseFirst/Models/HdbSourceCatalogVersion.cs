using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class HdbSourceCatalogVersion
{
    public string Version { get; set; } = null!;

    public DateTime UpgradedOn { get; set; }
}
