using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục quyền ký
/// </summary>
public partial class CategoryRoleSign
{
    public Guid RoleSignId { get; set; }

    /// <summary>
    /// mã quyền ký
    /// </summary>
    public string RoleSignCode { get; set; } = null!;

    /// <summary>
    /// tên quyền ký
    /// </summary>
    public string RoleSignName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CategorySignLevel> CategorySignLevels { get; set; } = new List<CategorySignLevel>();
}
