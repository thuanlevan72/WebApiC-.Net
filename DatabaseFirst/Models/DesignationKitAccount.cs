using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Bộ chỉ định -tài khoản
/// </summary>
public partial class DesignationKitAccount
{
    public Guid DesignationKitAccountId { get; set; }

    public Guid DesignationKitId { get; set; }

    public Guid AccountId { get; set; }

    public virtual CategoryEmployee Account { get; set; } = null!;

    public virtual CategoryDesignationKit DesignationKit { get; set; } = null!;
}
