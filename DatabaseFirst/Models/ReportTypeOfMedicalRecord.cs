using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Báo cáo -Loại bệnh án
/// </summary>
public partial class ReportTypeOfMedicalRecord
{
    public Guid ReportTypeOfMedicalRecordId { get; set; }

    public Guid ReportId { get; set; }

    public Guid TypeOfMedicalRecordId { get; set; }

    public virtual CategoryReport Report { get; set; } = null!;

    public virtual CategoryTypeOfMedicalRecord TypeOfMedicalRecord { get; set; } = null!;
}
