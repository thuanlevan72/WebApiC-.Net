using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// ngoài điều trị - Th kê dịch vụ
/// </summary>
public partial class OutsiteOfTreatmentServiceServiceList
{
    public Guid OutsiteOfTreatmentServiceServiceListId { get; set; }

    public Guid OutsiteOfTreatmentServiceId { get; set; }

    public Guid ServiceListId { get; set; }

    public virtual CategoryOutsiteOfTreatmentService OutsiteOfTreatmentService { get; set; } = null!;

    public virtual CategoryAttribute ServiceList { get; set; } = null!;
}
