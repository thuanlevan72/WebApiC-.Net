using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// phục hồi chức năng trường hợp kê dịch vụ
/// </summary>
public partial class RehabilitationServiceServiceList
{
    public Guid RehabilitationServiceServiceListId { get; set; }

    public Guid RehabilitationServiceId { get; set; }

    public Guid ServiceListId { get; set; }

    public virtual CategoryRehabilitationsService RehabilitationService { get; set; } = null!;

    public virtual CategoryAttribute ServiceList { get; set; } = null!;
}
