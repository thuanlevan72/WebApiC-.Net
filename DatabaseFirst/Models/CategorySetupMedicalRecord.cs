using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh sách lập bệnh án
/// </summary>
public partial class CategorySetupMedicalRecord
{
    public Guid SetupMedicalRecordId { get; set; }

    /// <summary>
    /// thông tin bệnh nhân
    /// </summary>
    public Guid? BasicInformationIpdId { get; set; }

    /// <summary>
    /// loại bệnh án
    /// </summary>
    public Guid MedicalRecordType { get; set; }

    /// <summary>
    /// mã bệnh án
    /// </summary>
    public string SetupMedicalRecordCode { get; set; } = null!;

    /// <summary>
    /// loại hình kb, cb
    /// </summary>
    public Guid AttributeId { get; set; }

    /// <summary>
    /// khoa nhập viện
    /// </summary>
    public Guid DepartmentId { get; set; }

    /// <summary>
    /// loại đối tượng
    /// </summary>
    public Guid? ObjectId { get; set; }

    public Guid CreatedBy { get; set; }

    /// <summary>
    /// trạng thái
    /// </summary>
    public int? IsStatus { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public int? IsActive { get; set; }

    /// <summary>
    /// thông tin ra viện
    /// </summary>
    public Guid? HospitalDischargeInfomationId { get; set; }

    public Guid? BasicInformationPatientId { get; set; }

    /// <summary>
    /// mã liên kết người bệnh từ patient_id lấy ra code
    /// </summary>
    public Guid? CodeReferId { get; set; }

    public virtual CategoryAttribute Attribute { get; set; } = null!;

    public virtual BasicInformationPatientIpd? BasicInformationIpd { get; set; }

    public virtual CategoryBasicInformationPatient? BasicInformationPatient { get; set; }

    public virtual ICollection<CategoryLongTermTreatment> CategoryLongTermTreatments { get; set; } = new List<CategoryLongTermTreatment>();

    public virtual CategoryPatient? CodeRefer { get; set; }

    public virtual CategoryAccount CreatedByNavigation { get; set; } = null!;

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual ICollection<DirectDepartment> DirectDepartments { get; set; } = new List<DirectDepartment>();

    public virtual CategoryHospitalDischargeInfomation? HospitalDischargeInfomation { get; set; }

    public virtual ICollection<MedicalRecordRoomBed> MedicalRecordRoomBeds { get; set; } = new List<MedicalRecordRoomBed>();

    public virtual CategoryTypeOfMedicalRecord MedicalRecordTypeNavigation { get; set; } = null!;

    public virtual CategoryObjectType? Object { get; set; }

    public virtual ICollection<SetupMedicalRecordSummary15Day> SetupMedicalRecordSummary15Days { get; set; } = new List<SetupMedicalRecordSummary15Day>();
}
