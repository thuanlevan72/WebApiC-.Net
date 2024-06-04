using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ giường - Phòng thực hiện
/// </summary>
public partial class BedServiceTabImplementationRoom
{
    public Guid BedServiceTabImplementRoomId { get; set; }

    public Guid BedServiceId { get; set; }

    public Guid TabImplementRoomId { get; set; }

    public virtual CategoryBedService BedService { get; set; } = null!;

    public virtual CategoryTabImplementationRoom TabImplementRoom { get; set; } = null!;
}
