using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// gói dịch vụ - khoa chỉ định
/// </summary>
public partial class PackageServiceDepartment
{
    public Guid PackageServiceDepartmentId { get; set; }

    public Guid PackageServiceId { get; set; }

    public Guid DepartmentId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual CategoryPackageService PackageService { get; set; } = null!;
}
