using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục mã khám bệnh
/// </summary>
public partial class CategoryExamineCode
{
    public Guid ExamineCodeId { get; set; }

    public Guid SpeciallistId { get; set; }

    public Guid DepartmentId { get; set; }

    public string HospitalSpecial { get; set; } = null!;

    public string HospitalTop1 { get; set; } = null!;

    public string HospitalTop2 { get; set; } = null!;

    public string HospitalTop3 { get; set; } = null!;

    public string HospitalTop4 { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual CategorySpecialist Speciallist { get; set; } = null!;
}
