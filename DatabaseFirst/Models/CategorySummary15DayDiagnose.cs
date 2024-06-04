using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// sơ kết 15 ngày  - chẩn đóa kèm theo
/// </summary>
public partial class CategorySummary15DayDiagnose
{
    public Guid Summary15DayDiagnoseId { get; set; }

    public Guid Summary15DayId { get; set; }

    public Guid DiagnoseNameId { get; set; }

    public string? DiagnoseNameText { get; set; }

    public virtual CategoryDiseaseName DiagnoseName { get; set; } = null!;

    public virtual CategorySummary15Day Summary15Day { get; set; } = null!;
}
