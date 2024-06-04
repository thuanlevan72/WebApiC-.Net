using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chỉ định dịch vụ xét nghiệm
/// </summary>
public partial class PatientDesignateServiceLaboratory
{
    public Guid PatientDesignateServiceLaboratoryId { get; set; }

    /// <summary>
    /// chỉ định dịch vụ
    /// </summary>
    public Guid PatientDesignateServiceId { get; set; }

    public string? Result { get; set; }

    public string? Conclude { get; set; }

    public string? Discuss { get; set; }

    /// <summary>
    /// thời gian tiếp nhận
    /// </summary>
    public DateTime? CreatedAt { get; set; }

    public int? IsStatus { get; set; }

    /// <summary>
    /// thời gian có kết quả
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? MachineCodeId { get; set; }

    public int? CodePrint { get; set; }

    public int? IsIpd { get; set; }

    public virtual CategoryMachine? MachineCode { get; set; }

    public virtual CategoryPatientDesignateService PatientDesignateService { get; set; } = null!;
}
