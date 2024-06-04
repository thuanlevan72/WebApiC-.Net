using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Đối tác - Nhóm dịch vụ
/// </summary>
public partial class PartnerGroupService
{
    public Guid PartnerGroupService1 { get; set; }

    public Guid PartnerId { get; set; }

    public Guid GroupServiceId { get; set; }

    public virtual CategoryGroupServiceLevel1 GroupService { get; set; } = null!;

    public virtual CategoryPartner Partner { get; set; } = null!;
}
