using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Lịch sử Đối tác - Nhóm dịch vụ
/// </summary>
public partial class HistoryPartnerGroupService
{
    public Guid HistoryPartnerGroupServiceId { get; set; }

    public Guid HistoryPartnerId { get; set; }

    public Guid GroupServiceId { get; set; }

    public virtual CategoryGroupServiceLevel1 GroupService { get; set; } = null!;

    public virtual CategoryHistoryPartner HistoryPartner { get; set; } = null!;
}
