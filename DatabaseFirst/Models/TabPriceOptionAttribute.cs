using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Tùy chọn giá - Nguồn chi trả khác
/// </summary>
public partial class TabPriceOptionAttribute
{
    public Guid TabPriceOptionAttributeId { get; set; }

    public Guid TabPriceOptionId { get; set; }

    public Guid AttributeId { get; set; }

    public virtual CategoryAttribute Attribute { get; set; } = null!;

    public virtual CategoryTabPriceOption TabPriceOption { get; set; } = null!;
}
