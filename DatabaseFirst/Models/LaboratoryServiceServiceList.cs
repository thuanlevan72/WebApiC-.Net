using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ xét nghiệm - trường hợp kê dịch vụ
/// </summary>
public partial class LaboratoryServiceServiceList
{
    public Guid LaboratoryServiceServiceListId { get; set; }

    public Guid LaboratoryServiceId { get; set; }

    public Guid ServiceListId { get; set; }

    public virtual CategoryLaboratoryService LaboratoryService { get; set; } = null!;

    public virtual CategoryAttribute ServiceList { get; set; } = null!;
}
