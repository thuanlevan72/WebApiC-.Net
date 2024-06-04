using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// thông tin ra viện - chẩn đoán kèm theo
/// </summary>
public partial class HospitalDischargeInfomationCompanying
{
    public Guid HospitalDischargeInfomationCompanyingId { get; set; }

    public Guid HospitalDischargeInfomationId { get; set; }

    public Guid DiagnoseId { get; set; }

    public string? DiagnoseNote { get; set; }

    public virtual CategoryDiseaseName Diagnose { get; set; } = null!;

    public virtual CategoryHospitalDischargeInfomation HospitalDischargeInfomation { get; set; } = null!;
}
