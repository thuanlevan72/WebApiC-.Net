using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Nhân viên - chuyên khoa
/// </summary>
public partial class EmployeeSpecialist
{
    public Guid EmployeeSpecialistId { get; set; }

    public Guid EmployeeId { get; set; }

    public Guid SpecialistId { get; set; }

    public virtual CategoryEmployee Employee { get; set; } = null!;

    public virtual CategorySpecialist Specialist { get; set; } = null!;
}
