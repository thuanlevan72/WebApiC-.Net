using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Mẫu diễn biến - khoa chỉ định
/// </summary>
public partial class TemplateOfDevelopmentsDepartment
{
    public Guid TemplateOfDevelopmentDepartmentId { get; set; }

    public Guid TemplateOfDevelopmentId { get; set; }

    public Guid DepartmentId { get; set; }

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual CategoryTemplateOfDevelopment TemplateOfDevelopment { get; set; } = null!;
}
