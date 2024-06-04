using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phiếu lĩnh - Phòng
/// </summary>
public partial class ReceiptCodeRoom
{
    public Guid ReceiptCodeRoomId { get; set; }

    public Guid ReceiptCodeId { get; set; }

    public Guid RoomId { get; set; }

    public virtual CategoryReceiptCode ReceiptCode { get; set; } = null!;

    public virtual CategoryRoom Room { get; set; } = null!;
}
