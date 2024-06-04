using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Vật tư - Mục đích sử dụng
/// </summary>
public partial class SuppliesPurposeUse
{
    public Guid SuppliesPurposeUseId { get; set; }

    public Guid SuppliesId { get; set; }

    public Guid PurposeUseAttributeId { get; set; }

    public virtual CategoryAttribute PurposeUseAttribute { get; set; } = null!;

    public virtual CategorySupply Supplies { get; set; } = null!;
}
