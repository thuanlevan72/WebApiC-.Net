using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thông tin phòng - nhà
/// </summary>
public partial class EmployeeDepartmentBuilding
{
    public Guid EmployeeDepartmentBuildingId { get; set; }

    public Guid EmployeeDepartmentId { get; set; }

    public Guid BuildingId { get; set; }

    public virtual CategoryBuilding Building { get; set; } = null!;

    public virtual EmployeeDepartment EmployeeDepartment { get; set; } = null!;
}
