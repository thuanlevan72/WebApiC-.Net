using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Khoa - Tính chất khoa
/// </summary>
public partial class DepartmentFacultyNature
{
    public Guid DepartmentFacultyNatureId { get; set; }

    public Guid DepartmentId { get; set; }

    public Guid FacultyNatureId { get; set; }

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual CategoryAttribute FacultyNature { get; set; } = null!;
}
