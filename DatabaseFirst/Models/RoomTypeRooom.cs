using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phòng - Loại Phong
/// </summary>
public partial class RoomTypeRooom
{
    public Guid RoomTypeRoomId { get; set; }

    public Guid RoomId { get; set; }

    public Guid TypeRoomId { get; set; }

    public virtual CategoryRoom Room { get; set; } = null!;

    public virtual CategoryAttribute TypeRoom { get; set; } = null!;
}
