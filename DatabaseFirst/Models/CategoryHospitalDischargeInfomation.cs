using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thông tin ra viện
/// </summary>
public partial class CategoryHospitalDischargeInfomation
{
    public Guid HospitalDischargeInfomationId { get; set; }

    /// <summary>
    /// thông tin bệnh nhân
    /// </summary>
    public Guid PatientId { get; set; }

    /// <summary>
    /// chẩn đoán ra viện chính
    /// </summary>
    public Guid? DiagnoseMainId { get; set; }

    /// <summary>
    /// chẩn đoán ra viện chi tiết
    /// </summary>
    public string? DiagnoseMainDetails { get; set; }

    /// <summary>
    /// phương pháp điều trị
    /// </summary>
    public string? Treatments { get; set; }

    /// <summary>
    /// tình trạng ra viện
    /// </summary>
    public int? HospitalDischargeStatus { get; set; }

    /// <summary>
    /// kết quả điều trị
    /// </summary>
    public int? TreatmentResult { get; set; }

    /// <summary>
    /// thời gian ra viện
    /// </summary>
    public DateTime? DischargeTime { get; set; }

    /// <summary>
    /// thời gian hẹn khám
    /// </summary>
    public DateTime? AppointmentTime { get; set; }

    /// <summary>
    /// phòng khám
    /// </summary>
    public Guid? RoomId { get; set; }

    /// <summary>
    /// lời dặn bác sĩ
    /// </summary>
    public string? DoctorRemind { get; set; }

    /// <summary>
    /// tình trạng người bệnh
    /// </summary>
    public string? PatientStatus { get; set; }

    /// <summary>
    /// quá trình bệnh lý và diễn biến lâm sàng
    /// </summary>
    public string? ClinicalProgress { get; set; }

    /// <summary>
    /// tóm tắt kết quả cls
    /// </summary>
    public string? SummaryCls { get; set; }

    /// <summary>
    /// hướng điều trị và các chế độ tiếp theo
    /// </summary>
    public string? TreatmentDirection { get; set; }

    /// <summary>
    /// mã số bhxh
    /// </summary>
    public string? InsuranceCode { get; set; }

    /// <summary>
    /// mã thẻ
    /// </summary>
    public string? InsuranceCard { get; set; }

    /// <summary>
    /// đình chỉ thai nghén
    /// </summary>
    public int? TerminationOfPregnancy { get; set; }

    /// <summary>
    /// tuổi thai
    /// </summary>
    public string? PregnancyAge { get; set; }

    /// <summary>
    /// nghỉ ngoại trú từ ngày
    /// </summary>
    public DateTime? FromDate { get; set; }

    /// <summary>
    /// nghỉ ngoại trú đến ngày
    /// </summary>
    public DateTime? ToDate { get; set; }

    /// <summary>
    /// Ngày chứng từ
    /// </summary>
    public DateTime? DocumentDate { get; set; }

    /// <summary>
    /// thủ trưởng đơn vị
    /// </summary>
    public string? UnitHeads { get; set; }

    /// <summary>
    /// nguyên nhân đình chỉ thai
    /// </summary>
    public string? TerminationOfPregnancyReason { get; set; }

    /// <summary>
    /// thời gian đình chỉ thai
    /// </summary>
    public DateTime? TerminationOfPregnancyTime { get; set; }

    /// <summary>
    /// trẻ em không thẻ :1 không phải 2 không phải trẻ em
    /// </summary>
    public int? IsChildCard { get; set; }

    /// <summary>
    /// tên trường khoa
    /// </summary>
    public Guid? AccountId { get; set; }

    /// <summary>
    /// họ tên cha
    /// </summary>
    public string? FatherName { get; set; }

    /// <summary>
    /// họ tên mẹ
    /// </summary>
    public string? MotherName { get; set; }

    public string? Phone { get; set; }

    public string? DiagnoseMainNote { get; set; }

    /// <summary>
    /// bv chuyển đến
    /// </summary>
    public Guid? HospitalId { get; set; }

    public virtual CategoryAccount? Account { get; set; }

    public virtual ICollection<CategorySetupMedicalRecord> CategorySetupMedicalRecords { get; set; } = new List<CategorySetupMedicalRecord>();

    public virtual CategoryDiseaseName? DiagnoseMain { get; set; }

    public virtual CategoryHospital? Hospital { get; set; }

    public virtual ICollection<HospitalDischargeInfomationCompanying> HospitalDischargeInfomationCompanyings { get; set; } = new List<HospitalDischargeInfomationCompanying>();

    public virtual CategoryPatient Patient { get; set; } = null!;

    public virtual CategoryRoom? Room { get; set; }
}
