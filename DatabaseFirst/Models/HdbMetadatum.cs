using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class HdbMetadatum
{
    public int Id { get; set; }

    public string Metadata { get; set; } = null!;

    public int ResourceVersion { get; set; }
}
