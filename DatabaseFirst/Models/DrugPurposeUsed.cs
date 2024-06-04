using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thuốc - mục đích sử dụng
/// </summary>
public partial class DrugPurposeUsed
{
    public Guid DrugPurposeUsedId { get; set; }

    public Guid DrugId { get; set; }

    public Guid PurposeUsedAttributeId { get; set; }

    public virtual CategoryDrug Drug { get; set; } = null!;

    public virtual CategoryAttribute PurposeUsedAttribute { get; set; } = null!;
}
