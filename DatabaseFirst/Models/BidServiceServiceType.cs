using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh sách thầu - loại dịch vụ
/// </summary>
public partial class BidServiceServiceType
{
    public Guid BidServiceServiceTypeId { get; set; }

    public Guid BidServiceId { get; set; }

    public Guid ServiceTypeId { get; set; }

    public virtual CategoryBidService BidService { get; set; } = null!;

    public virtual CategoryConcept ServiceType { get; set; } = null!;
}
