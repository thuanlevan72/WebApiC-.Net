using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Liều dùng bác sĩ - Danh sách thuốc
/// </summary>
public partial class DoctorDosageDrug
{
    public Guid DoctorDosageDrugId { get; set; }

    public Guid DoctorDosageId { get; set; }

    public Guid DrugId { get; set; }

    public int? IsActive { get; set; }

    public virtual CategoryDoctorDosage DoctorDosage { get; set; } = null!;

    public virtual CategoryDrug Drug { get; set; } = null!;
}
