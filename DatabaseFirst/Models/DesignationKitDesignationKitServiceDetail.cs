using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chi tiết bộ chỉ định
/// </summary>
public partial class DesignationKitDesignationKitServiceDetail
{
    public Guid DesignationKitServiceDetailsId { get; set; }

    public Guid DesignationKitServiceId { get; set; }

    public Guid DesignationKitId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public decimal? Total { get; set; }

    public virtual CategoryDesignationKit DesignationKit { get; set; } = null!;

    public virtual CategoryDesignationKitService DesignationKitService { get; set; } = null!;
}
