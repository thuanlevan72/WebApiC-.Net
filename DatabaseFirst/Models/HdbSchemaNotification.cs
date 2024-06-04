using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class HdbSchemaNotification
{
    public int Id { get; set; }

    public string Notification { get; set; } = null!;

    public int ResourceVersion { get; set; }

    public Guid InstanceId { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
