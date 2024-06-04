using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phòng thực hiện -phòng
/// </summary>
public partial class TabImplementationRoomsRoom
{
    public Guid TabImplementRoomRoomId { get; set; }

    public Guid TabImplementRoomId { get; set; }

    public Guid RoomId { get; set; }

    public virtual CategoryRoom Room { get; set; } = null!;

    public virtual CategoryTabImplementationRoom TabImplementRoom { get; set; } = null!;
}
