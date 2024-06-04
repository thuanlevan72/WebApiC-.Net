using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Gói mổ 10 ngày - dịch vụ chung
/// </summary>
public partial class CategoryGenerateProduct
{
    public Guid GenerateProductId { get; set; }

    public Guid ProductId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual CategoryProduct Product { get; set; } = null!;
}
