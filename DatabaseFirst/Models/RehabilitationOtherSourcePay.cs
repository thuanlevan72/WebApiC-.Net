using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phục hồi chức năng - nguồn chi trả khác
/// </summary>
public partial class RehabilitationOtherSourcePay
{
    public Guid RehabilitationServiceOtherSourcePayId { get; set; }

    public Guid RehabilitationServiceId { get; set; }

    public Guid OtherSourcePayId { get; set; }

    public virtual CategoryAttribute OtherSourcePay { get; set; } = null!;

    public virtual CategoryRehabilitationsService RehabilitationService { get; set; } = null!;
}
