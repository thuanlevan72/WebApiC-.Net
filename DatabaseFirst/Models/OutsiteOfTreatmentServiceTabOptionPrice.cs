using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ ngoài điều trị - Tùy chọn giá
/// </summary>
public partial class OutsiteOfTreatmentServiceTabOptionPrice
{
    public Guid OutSiteOfTreatmentTabOptionPriceId { get; set; }

    public Guid OutSiteOfTreatmentId { get; set; }

    public Guid TabOptionPriceId { get; set; }

    public virtual CategoryOutsiteOfTreatmentService OutSiteOfTreatment { get; set; } = null!;

    public virtual CategoryTabPriceOption TabOptionPrice { get; set; } = null!;
}
