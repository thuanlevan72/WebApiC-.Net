using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phẫu thuật thủ thuật - Trường hợp kê dịch vụ
/// </summary>
public partial class SurgicalProceduresServiceServiceList
{
    public Guid SurgicalProceduresServiceServiceListId { get; set; }

    public Guid SurgicalProceduresServiceId { get; set; }

    public Guid ServiceListId { get; set; }

    public virtual CategoryAttribute ServiceList { get; set; } = null!;

    public virtual CategorySurgicalProceduresService SurgicalProceduresService { get; set; } = null!;
}
