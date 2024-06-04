using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Khoa- Mượn giường tại khoa
/// </summary>
public partial class DepartmentBorrow
{
    public Guid DepartmentBorrowId { get; set; }

    public Guid DepartmentId { get; set; }

    public Guid DepartBorrowId { get; set; }

    public virtual CategoryDepartment DepartBorrow { get; set; } = null!;

    public virtual CategoryDepartment Department { get; set; } = null!;
}
