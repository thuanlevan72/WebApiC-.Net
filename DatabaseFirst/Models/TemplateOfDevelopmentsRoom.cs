using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Mẫu diễn biến - phòng
/// </summary>
public partial class TemplateOfDevelopmentsRoom
{
    public Guid TemplateOfDepartmentRoomId { get; set; }

    public Guid TemplateOfDepartmentId { get; set; }

    public Guid RoomId { get; set; }

    public virtual CategoryRoom Room { get; set; } = null!;

    public virtual CategoryTemplateOfDevelopment TemplateOfDepartment { get; set; } = null!;
}
