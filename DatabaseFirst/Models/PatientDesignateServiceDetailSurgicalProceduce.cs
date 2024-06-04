using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phẫu thuật thủ thuật - chỉ định dịch vụ
/// </summary>
public partial class PatientDesignateServiceDetailSurgicalProceduce
{
    public Guid PatientDesignateServiceDetailSurgicalProceduresId { get; set; }

    /// <summary>
    /// id của phẫu thuật thủ thuật
    /// </summary>
    public Guid PatientDesignateServiceSurgicalProceduresId { get; set; }

    /// <summary>
    /// id chỉ định dịch vụ
    /// </summary>
    public Guid PatientDesignateServiceId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual CategoryPatientDesignateService PatientDesignateService { get; set; } = null!;

    public virtual PatientDesignateServiceSurgicalProceduce PatientDesignateServiceSurgicalProcedures { get; set; } = null!;
}
