using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Kết luận khám - Nhập viện
/// </summary>
public partial class Hospitalize
{
    public Guid HospitalizeId { get; set; }

    /// <summary>
    /// thông tin bệnh nhân
    /// </summary>
    public Guid PatientId { get; set; }

    /// <summary>
    /// thông tin cơ bản bệnh nhân
    /// </summary>
    public Guid? BasicInformationPatientId { get; set; }

    /// <summary>
    /// buồng khám bệnh
    /// </summary>
    public Guid? RoomId { get; set; }

    /// <summary>
    /// ghi chú
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// loại đối tượng nội trú,ngoại trú
    /// </summary>
    public Guid? ConceptId { get; set; }

    /// <summary>
    /// số vào viện
    /// </summary>
    public int NumberOfHospitalizeId { get; set; }

    /// <summary>
    /// tên bệnh viện
    /// </summary>
    public string? HospitalName { get; set; }

    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// khoa
    /// </summary>
    public Guid? DepartmentId { get; set; }

    /// <summary>
    /// Họ tên người nhà
    /// </summary>
    public string? FullName { get; set; }

    /// <summary>
    /// só điện thoại
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// tóm tắt lâm sàng
    /// </summary>
    public string? SumaryClinic { get; set; }

    /// <summary>
    /// đã xử lý
    /// </summary>
    public string? Processed { get; set; }

    /// <summary>
    /// nơi làm việc
    /// </summary>
    public string? Workplace { get; set; }

    public virtual CategoryBasicInformationPatient? BasicInformationPatient { get; set; }

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryDepartment? Department { get; set; }

    public virtual ICollection<HopitalizeDentomaxillofacial> HopitalizeDentomaxillofacials { get; set; } = new List<HopitalizeDentomaxillofacial>();

    public virtual ICollection<HospitalizeEye> HospitalizeEyes { get; set; } = new List<HospitalizeEye>();

    public virtual ICollection<HospitalizeOtorhinolaryngology> HospitalizeOtorhinolaryngologies { get; set; } = new List<HospitalizeOtorhinolaryngology>();

    public virtual CategoryPatient Patient { get; set; } = null!;

    public virtual CategoryRoom? Room { get; set; }
}
