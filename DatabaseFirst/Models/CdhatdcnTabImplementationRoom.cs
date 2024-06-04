using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// CDHATDCN - Phòng thực hiện
/// </summary>
public partial class CdhatdcnTabImplementationRoom
{
    public Guid CdhaTdcnTabImplementationRoomId { get; set; }

    public Guid CdhaTdcnId { get; set; }

    public Guid TabImplementRoomId { get; set; }

    public virtual CategoryCdhatdcn CdhaTdcn { get; set; } = null!;

    public virtual CategoryTabImplementationRoom TabImplementRoom { get; set; } = null!;
}
