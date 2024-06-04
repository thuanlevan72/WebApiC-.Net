using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thuốc - khoa chỉ định
/// </summary>
public partial class DrugDepartment
{
    public Guid DrupElementId { get; set; }

    public Guid DrugId { get; set; }

    public Guid DepartmentId { get; set; }

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual CategoryDrug Drug { get; set; } = null!;
}
