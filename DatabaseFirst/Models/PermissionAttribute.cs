using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Quyeen - Thuộc tính
/// </summary>
public partial class PermissionAttribute
{
    public Guid PermissionAttributeId { get; set; }

    public Guid PermissionId { get; set; }

    public Guid AttributeId { get; set; }

    public virtual CategoryAttribute Attribute { get; set; } = null!;

    public virtual CategoryPermission Permission { get; set; } = null!;
}
