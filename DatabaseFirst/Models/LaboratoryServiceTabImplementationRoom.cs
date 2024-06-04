using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Xét nghiệm - phòng thực hiện
/// </summary>
public partial class LaboratoryServiceTabImplementationRoom
{
    public Guid LaboratoryServiceTabImplementRoomId { get; set; }

    public Guid LaboratoryServiceId { get; set; }

    public Guid TabImplementRoomId { get; set; }

    public virtual CategoryLaboratoryService LaboratoryService { get; set; } = null!;

    public virtual CategoryTabImplementationRoom TabImplementRoom { get; set; } = null!;
}
