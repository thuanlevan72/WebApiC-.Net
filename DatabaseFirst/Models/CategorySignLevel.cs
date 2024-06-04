using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục cấp ký
/// </summary>
public partial class CategorySignLevel
{
    public Guid SignLevelId { get; set; }

    public Guid SignTypeAttributeId { get; set; }

    public Guid RoleSignId { get; set; }

    public string NameSign { get; set; } = null!;

    public int IsActive { get; set; }

    public Guid? SetUpSignId { get; set; }

    public virtual CategoryRoleSign RoleSign { get; set; } = null!;

    public virtual CategorySetUpSign? SetUpSign { get; set; }
}
