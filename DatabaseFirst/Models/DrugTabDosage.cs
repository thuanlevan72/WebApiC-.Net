using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục Thuốc  tab liều dùng
/// </summary>
public partial class DrugTabDosage
{
    public Guid DrugDosageId { get; set; }

    public Guid DosageId { get; set; }

    public Guid DrugId { get; set; }

    public virtual CategoryDosage Dosage { get; set; } = null!;

    public virtual CategoryDrug Drug { get; set; } = null!;
}
