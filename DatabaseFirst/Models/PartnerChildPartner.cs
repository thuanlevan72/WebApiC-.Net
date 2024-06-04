using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Đối tác Đối tác con
/// </summary>
public partial class PartnerChildPartner
{
    public Guid PartnerChildPartnerId { get; set; }

    public Guid PartnerId { get; set; }

    public Guid ChildPartnerId { get; set; }

    public virtual CategoryChildPartner ChildPartner { get; set; } = null!;

    public virtual CategoryPartner Partner { get; set; } = null!;
}
