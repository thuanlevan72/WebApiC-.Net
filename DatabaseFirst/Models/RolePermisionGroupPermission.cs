using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Vai trò - quyền - nhóm tính năng
/// </summary>
public partial class RolePermisionGroupPermission
{
    public Guid RolePermissionGroupPermissionId { get; set; }

    public Guid RoleId { get; set; }

    public Guid PermissionId { get; set; }

    public Guid GroupPermissionId { get; set; }

    public Guid? AttributeId { get; set; }

    public virtual CategoryAttribute? Attribute { get; set; }

    public virtual CategoryGroupPermission GroupPermission { get; set; } = null!;

    public virtual CategoryPermission Permission { get; set; } = null!;

    public virtual CategoryRole Role { get; set; } = null!;
}
