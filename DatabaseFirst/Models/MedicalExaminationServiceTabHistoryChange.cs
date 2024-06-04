using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ khám bệnh - Lịch sử thay đổi
/// </summary>
public partial class MedicalExaminationServiceTabHistoryChange
{
    public Guid MedicalExaminationServiceTabHistoryChangedId { get; set; }

    public Guid MedicalExaminationServiceId { get; set; }

    public Guid TabHistoryChangeId { get; set; }

    public virtual CategoryMedicalExaminationService MedicalExaminationService { get; set; } = null!;

    public virtual CategoryTabHistoryChanged TabHistoryChange { get; set; } = null!;
}
