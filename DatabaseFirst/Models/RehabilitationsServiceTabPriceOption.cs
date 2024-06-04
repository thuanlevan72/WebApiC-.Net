using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phục hồi chức năng - Tùy chọn giá
/// </summary>
public partial class RehabilitationsServiceTabPriceOption
{
    public Guid RehabilitationServiceTabPriceOptionId { get; set; }

    public Guid RehabilitationServiceId { get; set; }

    public Guid TabPriceOptionId { get; set; }

    public virtual CategoryRehabilitationsService RehabilitationService { get; set; } = null!;

    public virtual CategoryTabPriceOption TabPriceOption { get; set; } = null!;
}
