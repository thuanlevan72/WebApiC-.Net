using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thông tin bệnh nhân
/// </summary>
public partial class CategoryPatient
{
    public Guid PatientId { get; set; }

    /// <summary>
    /// mã định danh
    /// </summary>
    public string IdentifierCode { get; set; } = null!;

    /// <summary>
    /// đối tượng
    /// </summary>
    public Guid? ObjectAttributeId { get; set; }

    /// <summary>
    /// loại đối tượng
    /// </summary>
    public Guid? ObjectTypeId { get; set; }

    /// <summary>
    /// mã người bệnh
    /// </summary>
    public string PatientCode { get; set; } = null!;

    /// <summary>
    /// họ tên
    /// </summary>
    public string FullName { get; set; } = null!;

    /// <summary>
    /// số điện thoại
    /// </summary>
    public string Phone { get; set; } = null!;

    /// <summary>
    /// ngày sinh
    /// </summary>
    public DateTime? Dob { get; set; }

    /// <summary>
    /// giờ sinh
    /// </summary>
    public DateTimeOffset? Tob { get; set; }

    /// <summary>
    /// Tuổi
    /// </summary>
    public string Age { get; set; } = null!;

    /// <summary>
    /// giới tính
    /// </summary>
    public int? Gender { get; set; }

    /// <summary>
    /// địa chỉ
    /// </summary>
    public string Address { get; set; } = null!;

    /// <summary>
    /// thành phố
    /// </summary>
    public Guid? CityId { get; set; }

    /// <summary>
    /// quận huyện
    /// </summary>
    public Guid? DistrictId { get; set; }

    /// <summary>
    /// phường xã
    /// </summary>
    public Guid? WardId { get; set; }

    /// <summary>
    /// thành phố(tạm trú)
    /// </summary>
    public Guid? CityTempId { get; set; }

    /// <summary>
    /// Quận huyện (tạm trú)
    /// </summary>
    public Guid? DistrictTempId { get; set; }

    /// <summary>
    /// Xã phường (tạm trú)
    /// </summary>
    public Guid? WardTempId { get; set; }

    /// <summary>
    /// Địa chỉ (tạm trú)
    /// </summary>
    public string? AddressTempId { get; set; }

    /// <summary>
    /// dân tộc
    /// </summary>
    public Guid? EthnicId { get; set; }

    /// <summary>
    /// quốc gia
    /// </summary>
    public Guid? NationalId { get; set; }

    /// <summary>
    /// loại giấy tờ tùy thân
    /// </summary>
    public int? IdentitiesType { get; set; }

    /// <summary>
    /// mã giấy tờ tùy thân
    /// </summary>
    public string IdentitiesCode { get; set; } = null!;

    /// <summary>
    /// ngày cấp
    /// </summary>
    public DateTime? DateRange { get; set; }

    /// <summary>
    /// nơi cấp
    /// </summary>
    public string IssuedBy { get; set; } = null!;

    /// <summary>
    /// email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// địa chỉ tại nước ngoài
    /// </summary>
    public string AddressAbroad { get; set; } = null!;

    /// <summary>
    /// nghề nghiệp
    /// </summary>
    public Guid? JobId { get; set; }

    /// <summary>
    /// mã bhxh
    /// </summary>
    public char InsuranceCode { get; set; }

    /// <summary>
    /// Xác nhận thông tin
    /// </summary>
    public int IsConfirm { get; set; }

    /// <summary>
    /// ảnh cccd mặt trước
    /// </summary>
    public string? IdentitesFront { get; set; }

    /// <summary>
    /// ảnh cccd mặt sau
    /// </summary>
    public string? IdentitiesBack { get; set; }

    /// <summary>
    /// hiệu lực
    /// </summary>
    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    /// <summary>
    /// nb covid
    /// </summary>
    public int? IsCovid { get; set; }

    /// <summary>
    /// ưu tiên
    /// </summary>
    public int? IsPriority { get; set; }

    public int? IsStatus { get; set; }

    /// <summary>
    /// quầy
    /// </summary>
    public Guid? CounterId { get; set; }

    /// <summary>
    /// cấp cứu
    /// </summary>
    public int? IsEmergency { get; set; }

    /// <summary>
    /// đối tượng miễn giảm
    /// </summary>
    public Guid? SubjectOfExemptionId { get; set; }

    public string? Avatar { get; set; }

    /// <summary>
    /// loại đối tượng
    /// </summary>
    public Guid? IsIpdOrOpd { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<BasicInformationPatientIpd> BasicInformationPatientIpds { get; set; } = new List<BasicInformationPatientIpd>();

    public virtual ICollection<CategoryAppoiment> CategoryAppoiments { get; set; } = new List<CategoryAppoiment>();

    public virtual ICollection<CategoryAppointmentOther> CategoryAppointmentOthers { get; set; } = new List<CategoryAppointmentOther>();

    public virtual ICollection<CategoryBasicInformationPatient> CategoryBasicInformationPatients { get; set; } = new List<CategoryBasicInformationPatient>();

    public virtual ICollection<CategoryBiosignal> CategoryBiosignals { get; set; } = new List<CategoryBiosignal>();

    public virtual ICollection<CategoryHospitalDischargeInfomation> CategoryHospitalDischargeInfomations { get; set; } = new List<CategoryHospitalDischargeInfomation>();

    public virtual ICollection<CategoryInjectionAppointment> CategoryInjectionAppointments { get; set; } = new List<CategoryInjectionAppointment>();

    public virtual ICollection<CategoryLongTermTreatment> CategoryLongTermTreatments { get; set; } = new List<CategoryLongTermTreatment>();

    public virtual ICollection<CategoryPatientReception> CategoryPatientReceptions { get; set; } = new List<CategoryPatientReception>();

    public virtual ICollection<CategoryRefund> CategoryRefunds { get; set; } = new List<CategoryRefund>();

    public virtual ICollection<CategoryRoomBed> CategoryRoomBeds { get; set; } = new List<CategoryRoomBed>();

    public virtual ICollection<CategorySetupMedicalRecord> CategorySetupMedicalRecords { get; set; } = new List<CategorySetupMedicalRecord>();

    public virtual ICollection<CdhaTdcnList> CdhaTdcnLists { get; set; } = new List<CdhaTdcnList>();

    public virtual CategoryCity? City { get; set; }

    public virtual CategoryCity? CityTemp { get; set; }

    public virtual CategoryCounter? Counter { get; set; }

    public virtual ICollection<DirectHospitalize> DirectHospitalizes { get; set; } = new List<DirectHospitalize>();

    public virtual CategoryDistrict? District { get; set; }

    public virtual CategoryDistrict? DistrictTemp { get; set; }

    public virtual ICollection<DocumentTemplateResultCdha> DocumentTemplateResultCdhas { get; set; } = new List<DocumentTemplateResultCdha>();

    public virtual CategoryEthnic? Ethnic { get; set; }

    public virtual ICollection<Hospitalize> Hospitalizes { get; set; } = new List<Hospitalize>();

    public virtual CategoryAttribute? IsIpdOrOpdNavigation { get; set; }

    public virtual CategoryJob? Job { get; set; }

    public virtual CategoryNational? National { get; set; }

    public virtual CategoryAttribute? ObjectAttribute { get; set; }

    public virtual CategoryObjectType? ObjectType { get; set; }

    public virtual ICollection<PatientAdvanceReceipt> PatientAdvanceReceipts { get; set; } = new List<PatientAdvanceReceipt>();

    public virtual ICollection<PatientEmergency> PatientEmergencies { get; set; } = new List<PatientEmergency>();

    public virtual ICollection<PatientInsurance> PatientInsurances { get; set; } = new List<PatientInsurance>();

    public virtual ICollection<PatientPackageService> PatientPackageServices { get; set; } = new List<PatientPackageService>();

    public virtual ICollection<PatientRelation> PatientRelations { get; set; } = new List<PatientRelation>();

    public virtual CategorySubjectOfExemption? SubjectOfExemption { get; set; }

    public virtual CategoryWard? Ward { get; set; }

    public virtual CategoryWard? WardTemp { get; set; }
}
