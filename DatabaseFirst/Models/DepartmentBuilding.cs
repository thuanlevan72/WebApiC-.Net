using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Khoa - Nhà
/// </summary>
public partial class DepartmentBuilding
{
    public Guid DepartmentBuildingId { get; set; }

    public Guid DepartmentId { get; set; }

    public Guid BuildingId { get; set; }

    public virtual CategoryBuilding Building { get; set; } = null!;

    public virtual CategoryDepartment Department { get; set; } = null!;
}
