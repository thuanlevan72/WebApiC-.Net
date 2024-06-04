using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ khám bệnh - Khoa chỉ định dịch vụ
/// </summary>
public partial class MedicalExaminationServiceDepartmentAssign
{
    public Guid MedicalExaminationServiceDepartmentAssignId { get; set; }

    public Guid MedicalExaminationServiceId { get; set; }

    public Guid DepartmentId { get; set; }

    public int IsActive { get; set; }

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual CategoryMedicalExaminationService MedicalExaminationService { get; set; } = null!;
}
