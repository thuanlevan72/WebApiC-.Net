using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nhóm vật tư
/// </summary>
public partial class CategoryGroupMaterial
{
    public Guid GroupMaterialId { get; set; }

    /// <summary>
    /// mã vật tư
    /// </summary>
    public string GroupMaterialCode { get; set; } = null!;

    /// <summary>
    /// tên vật tư
    /// </summary>
    public string GroupMaterialName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategorySupply> CategorySupplies { get; set; } = new List<CategorySupply>();
}
