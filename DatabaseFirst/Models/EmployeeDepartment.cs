using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// nhân viên - thông tinkhoa phòng - nhà
/// </summary>
public partial class EmployeeDepartment
{
    public Guid EmployeeDepartmentId { get; set; }

    public Guid DepartmentId { get; set; }

    public Guid EmployeeId { get; set; }

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual CategoryEmployee Employee { get; set; } = null!;

    public virtual ICollection<EmployeeDepartmentBuilding> EmployeeDepartmentBuildings { get; set; } = new List<EmployeeDepartmentBuilding>();

    public virtual ICollection<EmployeeDepartmentRoom> EmployeeDepartmentRooms { get; set; } = new List<EmployeeDepartmentRoom>();
}
