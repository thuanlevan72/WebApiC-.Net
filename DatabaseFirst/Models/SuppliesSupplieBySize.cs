using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Vật tư - Vật tư theo kích cỡ
/// </summary>
public partial class SuppliesSupplieBySize
{
    public Guid SuppliesSuppliesBySizeId { get; set; }

    public Guid SuppliesId { get; set; }

    public Guid SuppliesBySizeId { get; set; }

    public virtual CategorySupply Supplies { get; set; } = null!;

    public virtual CategorySupplieBySize SuppliesBySize { get; set; } = null!;
}
