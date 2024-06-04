using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// nhân viên thông tin khoa phòng phòng
/// </summary>
public partial class EmployeeDepartmentRoom
{
    public Guid EmployeeDepartmentRoomId { get; set; }

    public Guid EmployeeDepartmentId { get; set; }

    public Guid RoomId { get; set; }

    public virtual EmployeeDepartment EmployeeDepartment { get; set; } = null!;

    public virtual CategoryRoom Room { get; set; } = null!;
}
