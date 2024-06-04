using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục loại máy in
/// </summary>
public partial class CategoryPrintType
{
    public Guid PrintTypeId { get; set; }

    public Guid? PrintTypeIp { get; set; }

    public Guid PaperSizeAttributeId { get; set; }

    public int Horizontal { get; set; }

    public int Vertical { get; set; }

    public Guid PaperDirectionAttributeId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public Guid? PrintNameId { get; set; }

    public virtual CategoryAttribute PaperDirectionAttribute { get; set; } = null!;

    public virtual CategoryAttribute PaperSizeAttribute { get; set; } = null!;

    public virtual CategoryPrintName? PrintName { get; set; }

    public virtual CategoryAttribute? PrintTypeIpNavigation { get; set; }
}
