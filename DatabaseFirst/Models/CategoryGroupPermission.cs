using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nhóm tính năng
/// </summary>
public partial class CategoryGroupPermission
{
    public Guid GroupPermissionId { get; set; }

    public string GroupPermissionCode { get; set; } = null!;

    public string GroupPermissionName { get; set; } = null!;

    public string GroupPermissionDesc { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public int? IsOrder { get; set; }

    public Guid? ParentId { get; set; }

    public virtual ICollection<PermissionGroupPermission> PermissionGroupPermissions { get; set; } = new List<PermissionGroupPermission>();

    public virtual ICollection<RolePermisionGroupPermission> RolePermisionGroupPermissions { get; set; } = new List<RolePermisionGroupPermission>();
}
