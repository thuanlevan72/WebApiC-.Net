using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phẫu thuật thủ thuật - phòng thực hiện
/// </summary>
public partial class SurgicalProceduresServiceTabImplementationRoom
{
    public Guid SurgicalProceduresServiceTabImplementationRoomId { get; set; }

    public Guid SurgicalProceduresServiceId { get; set; }

    public Guid TabImplementRoomId { get; set; }

    public virtual CategorySurgicalProceduresService SurgicalProceduresService { get; set; } = null!;

    public virtual CategoryTabImplementationRoom TabImplementRoom { get; set; } = null!;
}
