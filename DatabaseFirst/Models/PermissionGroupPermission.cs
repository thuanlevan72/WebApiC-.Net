using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Quyền  - Nhóm tính năng
/// </summary>
public partial class PermissionGroupPermission
{
    public Guid PermissionGroupPermissionId { get; set; }

    public Guid PermissionId { get; set; }

    public Guid GroupPermissionId { get; set; }

    public virtual CategoryGroupPermission GroupPermission { get; set; } = null!;

    public virtual CategoryPermission Permission { get; set; } = null!;
}
