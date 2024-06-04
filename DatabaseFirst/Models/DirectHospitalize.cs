using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Kết thúc khám - chuyển viện
/// </summary>
public partial class DirectHospitalize
{
    public Guid DirectHospitalizeId { get; set; }

    /// <summary>
    /// kính gửi
    /// </summary>
    public Guid HospitalId { get; set; }

    public Guid PatientId { get; set; }

    /// <summary>
    /// nghè nghiệp
    /// </summary>
    public Guid? JobId { get; set; }

    public string? Phone { get; set; }

    /// <summary>
    /// bv đã khám và điều trị
    /// </summary>
    public Guid? HospitalId2 { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    /// <summary>
    /// dấu hiệu lâm sàng
    /// </summary>
    public string? ClinicalSigns { get; set; }

    /// <summary>
    /// kết quả cận lâm sàng
    /// </summary>
    public string? ResultClinicalSigns { get; set; }

    /// <summary>
    /// lý do chuyên : 1 đủ điều kiện, 2 là không phù hợp với khả năng 3 là theo yêu cầu
    /// </summary>
    public int? ReasonDirect { get; set; }

    /// <summary>
    /// hướng điều trị
    /// </summary>
    public string? DirectExamine { get; set; }

    /// <summary>
    /// phương tiện vận chuyển
    /// </summary>
    public string? VehicleDirect { get; set; }

    /// <summary>
    /// người hộ tống
    /// </summary>
    public string? FullName { get; set; }

    /// <summary>
    /// phương pháp điều trị
    /// </summary>
    public string? MethodExamine { get; set; }

    /// <summary>
    /// trạng thái điều trị
    /// </summary>
    public string? StatusExamine { get; set; }

    public Guid? BasicInformationPatientId { get; set; }

    public DateTime? FromDate1 { get; set; }

    public DateTime? ToDate1 { get; set; }

    public Guid? Hospital3 { get; set; }

    public string? Workplace { get; set; }

    /// <summary>
    /// chuyển tuyến hồi
    /// </summary>
    public DateTime? CreatedAt { get; set; }

    public virtual CategoryBasicInformationPatient? BasicInformationPatient { get; set; }

    public virtual CategoryHospital Hospital { get; set; } = null!;

    public virtual CategoryHospital? Hospital3Navigation { get; set; }

    public virtual CategoryHospital? HospitalId2Navigation { get; set; }

    public virtual CategoryJob? Job { get; set; }

    public virtual CategoryPatient Patient { get; set; } = null!;
}
