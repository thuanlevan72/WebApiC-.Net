using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục hội đồng
/// </summary>
public partial class CategoryCouncil
{
    public Guid CouncilId { get; set; }

    /// <summary>
    /// mã hội đồng
    /// </summary>
    public string CouncilCode { get; set; } = null!;

    /// <summary>
    /// tên hội đồng
    /// </summary>
    public string CouncilName { get; set; } = null!;

    /// <summary>
    /// Loại hội đồng
    /// </summary>
    public Guid CouncilTypeAttribute { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CouncilDetailCouncil> CouncilDetailCouncils { get; set; } = new List<CouncilDetailCouncil>();

    public virtual CategoryAttribute CouncilTypeAttributeNavigation { get; set; } = null!;
}
