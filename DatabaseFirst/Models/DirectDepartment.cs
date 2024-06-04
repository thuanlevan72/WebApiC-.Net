using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chuyển khoa
/// </summary>
public partial class DirectDepartment
{
    public Guid DirectDepartmentId { get; set; }

    public Guid SetupMedicalRecordId { get; set; }

    public DateTime TimeDirection { get; set; }

    /// <summary>
    /// Khoa chuyển đến
    /// </summary>
    public Guid DeparmentDirectionId { get; set; }

    /// <summary>
    /// Khoa chuyển đi
    /// </summary>
    public Guid DepartmentLeaveId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual CategoryDepartment DeparmentDirection { get; set; } = null!;

    public virtual CategoryDepartment DepartmentLeave { get; set; } = null!;

    public virtual CategorySetupMedicalRecord SetupMedicalRecord { get; set; } = null!;
}
