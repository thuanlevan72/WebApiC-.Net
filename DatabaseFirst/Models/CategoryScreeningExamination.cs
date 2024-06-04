using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Khám sàng lọc
/// </summary>
public partial class CategoryScreeningExamination
{
    public Guid ScreeningExaminationId { get; set; }

    public Guid PatientDesignateServiceId { get; set; }

    public string DataExamination { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? AccountId { get; set; }

    public virtual CategoryAccount? Account { get; set; }

    public virtual CategoryPatientDesignateService PatientDesignateService { get; set; } = null!;
}
