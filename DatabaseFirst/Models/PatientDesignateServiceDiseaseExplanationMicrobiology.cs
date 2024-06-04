using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chỉ định dịch vụ - giải phãu bệnh và vi sinh
/// </summary>
public partial class PatientDesignateServiceDiseaseExplanationMicrobiology
{
    public Guid PatientDesignateServiceDiseaseExplanationMicrobiologyId { get; set; }

    public Guid PatientDesignateServiceId { get; set; }

    /// <summary>
    /// tính chất bệnh phẩm 1:đạt 0 không đạt
    /// </summary>
    public int? SpecimenProperties { get; set; }

    /// <summary>
    /// kết quả
    /// </summary>
    public string Result { get; set; } = null!;

    /// <summary>
    /// kết luận
    /// </summary>
    public string? Conclude { get; set; }

    /// <summary>
    /// bàn luận
    /// </summary>
    public string? Suggest { get; set; }

    /// <summary>
    /// mã máy
    /// </summary>
    public Guid? MachineId { get; set; }

    /// <summary>
    /// trạng thái
    /// </summary>
    public int? IsStatus { get; set; }

    /// <summary>
    /// thời gian tiếp nhận
    /// </summary>
    public DateTime? CreatedAt { get; set; }

    public int? CodePrint { get; set; }

    /// <summary>
    /// thời gian có kết quả
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    public int? IsIpd { get; set; }

    public virtual CategoryMachine? Machine { get; set; }

    public virtual CategoryPatientDesignateService PatientDesignateService { get; set; } = null!;
}
