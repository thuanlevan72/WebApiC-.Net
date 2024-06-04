using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phẫu thuật thủ thuật - Tùy chọn giá
/// </summary>
public partial class SurgicalProceduresServiceTabPriceOption
{
    public Guid SurgicalProceduresServiceTabPriceOptionId { get; set; }

    public Guid SurgicalProceduresServiceId { get; set; }

    public Guid TabPriceOptionId { get; set; }

    public virtual CategorySurgicalProceduresService SurgicalProceduresService { get; set; } = null!;

    public virtual CategoryTabPriceOption TabPriceOption { get; set; } = null!;
}
