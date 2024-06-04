using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Xét nghiệm - Tùy chọn giá
/// </summary>
public partial class LaboratoryServiceTabPriceOption
{
    public Guid LabaratoryServiceTabPriceOptionId { get; set; }

    public Guid LabaratoryServiceId { get; set; }

    public Guid TabPriceOptionId { get; set; }

    public virtual CategoryLaboratoryService LabaratoryService { get; set; } = null!;

    public virtual CategoryTabPriceOption TabPriceOption { get; set; } = null!;
}
