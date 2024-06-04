using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục quyền
/// </summary>
public partial class CategoryPermission
{
    public Guid PermissionId { get; set; }

    public string PermissionCode { get; set; } = null!;

    public string PermissionName { get; set; } = null!;

    public string? PermissionDesc { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    /// <summary>
    /// url
    /// </summary>
    public string? Slug { get; set; }

    public int? IsOrder { get; set; }

    public Guid? ParrentId { get; set; }

    public virtual ICollection<PermissionAttribute> PermissionAttributes { get; set; } = new List<PermissionAttribute>();

    public virtual ICollection<PermissionGroupPermission> PermissionGroupPermissions { get; set; } = new List<PermissionGroupPermission>();

    public virtual ICollection<RolePermisionGroupPermission> RolePermisionGroupPermissions { get; set; } = new List<RolePermisionGroupPermission>();
}
