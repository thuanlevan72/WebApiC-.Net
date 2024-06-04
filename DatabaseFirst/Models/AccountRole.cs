using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Tài khoản - Vai trò
/// </summary>
public partial class AccountRole
{
    public Guid AccountRoleId { get; set; }

    public Guid AccountId { get; set; }

    public Guid RoleId { get; set; }

    public virtual CategoryAccount Account { get; set; } = null!;

    public virtual CategoryRole Role { get; set; } = null!;
}
