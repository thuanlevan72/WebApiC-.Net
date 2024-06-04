using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chuyển phòng khám
/// </summary>
public partial class DirectMedicalExamie
{
    public Guid DirectMedicalExamineId { get; set; }

    /// <summary>
    /// phòng trước khi chuyển
    /// </summary>
    public Guid RoomId { get; set; }

    /// <summary>
    /// chỉ định dịch vụ trước
    /// </summary>
    public Guid PatientDesignateServiceId { get; set; }

    /// <summary>
    /// thông tin bệnh nhân
    /// </summary>
    public Guid? BasicInformationId { get; set; }

    /// <summary>
    /// phòng chuyển
    /// </summary>
    public Guid RoomDirectId { get; set; }

    /// <summary>
    /// lý do
    /// </summary>
    public string Reason { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    /// <summary>
    /// chỉ định dịch vụ sau khi đổi
    /// </summary>
    public Guid? DirectPatientDesignateServiceId { get; set; }

    public virtual CategoryBasicInformationPatient? BasicInformation { get; set; }

    public virtual CategoryPatientDesignateService? DirectPatientDesignateService { get; set; }

    public virtual CategoryPatientDesignateService PatientDesignateService { get; set; } = null!;

    public virtual CategoryRoom Room { get; set; } = null!;

    public virtual CategoryRoom RoomDirect { get; set; } = null!;
}
