using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục chi tiết hội đồng
/// </summary>
public partial class CategoryCouncilDetail
{
    public Guid CouncilDetailId { get; set; }

    public Guid EmployeeId { get; set; }

    public Guid RoleAttributeId { get; set; }

    public string Position { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CouncilDetailCouncil> CouncilDetailCouncils { get; set; } = new List<CouncilDetailCouncil>();

    public virtual CategoryEmployee Employee { get; set; } = null!;

    public virtual CategoryAttribute RoleAttribute { get; set; } = null!;
}
