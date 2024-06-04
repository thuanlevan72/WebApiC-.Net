using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Bộ chỉ định - Khoa chỉ định dịch vụ
/// </summary>
public partial class DesignationKitDesignatedFaculty
{
    public Guid DesignationKitDesignatedFacultyId { get; set; }

    public Guid DesignationKitId { get; set; }

    public Guid DepartmentId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual CategoryDesignationKit DesignationKit { get; set; } = null!;
}
