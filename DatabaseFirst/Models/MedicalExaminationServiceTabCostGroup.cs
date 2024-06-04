using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ khám bệnh - Nhóm chi phí
/// </summary>
public partial class MedicalExaminationServiceTabCostGroup
{
    public Guid MedicalExaminationServiceTabCostGroupId { get; set; }

    public Guid MedicalExaminationServiceId { get; set; }

    public Guid TabCostGroupId { get; set; }

    public virtual CategoryMedicalExaminationService MedicalExaminationService { get; set; } = null!;

    public virtual CategoryTabCostGroup TabCostGroup { get; set; } = null!;
}
