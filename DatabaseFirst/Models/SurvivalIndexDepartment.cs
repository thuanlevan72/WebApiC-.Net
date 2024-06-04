using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chỉ số sống - Khoa chỉ định
/// </summary>
public partial class SurvivalIndexDepartment
{
    public Guid SurvivalIndexDepartment1 { get; set; }

    public Guid SurvivalIndexId { get; set; }

    public Guid DepartmentId { get; set; }

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual CategorySurvivalIndex SurvivalIndex { get; set; } = null!;
}
