using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// danh mục phương pháp nhuộm
/// </summary>
public partial class CategoryDyeingMethod
{
    public Guid DyeingMethodId { get; set; }

    public string DyeingMethodCode { get; set; } = null!;

    public string DyeingMethodName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }
}
