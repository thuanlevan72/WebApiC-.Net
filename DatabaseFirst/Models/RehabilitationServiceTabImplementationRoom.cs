using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phẫu thuật thủ thuật - phòng thực hiện
/// </summary>
public partial class RehabilitationServiceTabImplementationRoom
{
    public Guid RehabilitationServiceTabImplementationRoomId { get; set; }

    public Guid RehabilitationServiceId { get; set; }

    public Guid TabImplementRoomId { get; set; }

    public virtual CategoryRehabilitationsService RehabilitationService { get; set; } = null!;

    public virtual CategoryTabImplementationRoom TabImplementRoom { get; set; } = null!;
}
