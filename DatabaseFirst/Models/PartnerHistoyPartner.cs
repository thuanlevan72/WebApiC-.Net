using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Đối tác - Lịch sử thay đổi
/// </summary>
public partial class PartnerHistoyPartner
{
    public Guid PartnerHistoryPartnerId { get; set; }

    public Guid PartnerId { get; set; }

    public Guid HistoryPartnerId { get; set; }

    public virtual CategoryHistoryPartner HistoryPartner { get; set; } = null!;

    public virtual CategoryPartner Partner { get; set; } = null!;
}
