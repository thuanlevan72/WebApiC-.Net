using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ ngoài điều trị - Nguồn khác chi trả
/// </summary>
public partial class OutsiteOfTreatmentServiceOtherSourcePay
{
    public Guid OutsiteOfTreatmentServiceOtherSourcePayId { get; set; }

    public Guid OutsiteOfTreatmentServiceId { get; set; }

    public Guid OtherSourcePayId { get; set; }

    public virtual CategoryAttribute OtherSourcePay { get; set; } = null!;

    public virtual CategoryOutsiteOfTreatmentService OutsiteOfTreatmentService { get; set; } = null!;
}
