using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục ngoài điều trị - trường hợp kê dv
/// </summary>
public partial class MedicalExaminationServiceServiceList
{
    public Guid MedicalExaminationServiceServiceListId { get; set; }

    public Guid MedicalExaminationServiceId { get; set; }

    public Guid ServiceListId { get; set; }

    public virtual CategoryMedicalExaminationService MedicalExaminationService { get; set; } = null!;

    public virtual CategoryAttribute ServiceList { get; set; } = null!;
}
