using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class Viewcheckcontrain
{
    public string? TableName { get; set; }

    public string? ColumnName { get; set; }

    public string? ForeignTableName { get; set; }
}
