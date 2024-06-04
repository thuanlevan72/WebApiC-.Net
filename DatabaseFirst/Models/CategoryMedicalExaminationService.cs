using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục khám bệnh
/// </summary>
public partial class CategoryMedicalExaminationService
{
    public Guid MedicalExaminationServiceId { get; set; }

    /// <summary>
    /// mã dịch vụ khám bệnh
    /// </summary>
    public string MedicalExaminationServiceCode { get; set; } = null!;

    /// <summary>
    /// tên dịch vụ khám bệnh
    /// </summary>
    public string MedicalExaminationServiceName { get; set; } = null!;

    /// <summary>
    /// mã tương đương
    /// </summary>
    public string? EquivalentCode { get; set; }

    /// <summary>
    /// tên tương đương
    /// </summary>
    public string? EquivalentName { get; set; }

    /// <summary>
    /// giá không bảo hiểm
    /// </summary>
    public double PriceNonInsurance { get; set; }

    /// <summary>
    /// giá bảo hiểm
    /// </summary>
    public double? PriceInsurance { get; set; }

    /// <summary>
    /// tên viết tắt
    /// </summary>
    public string? Abbreviations { get; set; }

    /// <summary>
    /// phụ thu
    /// </summary>
    public double? Surcharge { get; set; }

    /// <summary>
    /// Tỷ lệ BH thanh toán
    /// </summary>
    public int? PaymentInsuranceRatio { get; set; }

    /// <summary>
    /// Tỷ lệ thanh toán DV
    /// </summary>
    public int PaymentServiceRatio { get; set; }

    /// <summary>
    /// chuyên khoa
    /// </summary>
    public Guid? SpecialistId { get; set; }

    /// <summary>
    /// nhóm dịch vụ cấp 1
    /// </summary>
    public Guid GroupServiceLvl1 { get; set; }

    /// <summary>
    /// nhóm dịch vụ cấp 2
    /// </summary>
    public Guid? GroupServiceLvl2 { get; set; }

    /// <summary>
    /// nhóm dịch vụ cấp 3
    /// </summary>
    public Guid? GroupServiceLvl3 { get; set; }

    /// <summary>
    /// đơn vj tính
    /// </summary>
    public Guid? UnitId { get; set; }

    /// <summary>
    /// Số ngày cảnh báo kê dịch vụ BHYT
    /// </summary>
    public int? InsuranceWarningNumberDay { get; set; }

    /// <summary>
    /// Số ngày cảnh báo HSD
    /// </summary>
    public int? ExpiredWarningNumberDay { get; set; }

    /// <summary>
    /// Giới tính
    /// </summary>
    public int? Gender { get; set; }

    /// <summary>
    /// CSKCB chuyển giao DVKT
    /// </summary>
    public Guid? TechServiceTranferUnitMedicalId { get; set; }

    /// <summary>
    /// CSKCB thực hiện CLS
    /// </summary>
    public Guid? ClsImplementUnitMedicalId { get; set; }

    /// <summary>
    /// Thứ tự hiển thị
    /// </summary>
    public int? DisplayOrder { get; set; }

    /// <summary>
    /// Đơn vị
    /// </summary>
    public string? UnitName { get; set; }

    /// <summary>
    /// Không tính tiền
    /// </summary>
    public int? IsNoCharge { get; set; }

    /// <summary>
    /// Hạn chế khoa chỉ định
    /// </summary>
    public int? IsRetrictDepartment { get; set; }

    /// <summary>
    /// Thanh toán sau
    /// </summary>
    public int? IsLaterPay { get; set; }

    /// <summary>
    /// Dùng cho Covid
    /// </summary>
    public int? IsUseCovid { get; set; }

    /// <summary>
    /// DV theo yêu cầu
    /// </summary>
    public int? IsRequestService { get; set; }

    /// <summary>
    /// Đặt khám online
    /// </summary>
    public int? IsBookOnline { get; set; }

    /// <summary>
    /// Thu ngoài
    /// </summary>
    public int? IsExternalPay { get; set; }

    /// <summary>
    /// Hiển thị lên KIOSK
    /// </summary>
    public int? IsKiosk { get; set; }

    /// <summary>
    /// Tách số lượng khi kê
    /// </summary>
    public int? IsListQtySplit { get; set; }

    /// <summary>
    /// Cho sửa đổi DV
    /// </summary>
    public int? IsEditService { get; set; }

    /// <summary>
    /// Không được thực hiện SL nhiều cùng lúc
    /// </summary>
    public int? IsNotImplemnetQtyMutil { get; set; }

    public int? IsECrCl { get; set; }

    public int? IsEGfr { get; set; }

    public int? IsActive { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public DateOnly? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid? ConceptId { get; set; }

    /// <summary>
    /// tài khoản doanh thu
    /// </summary>
    public string? AccountRevenue { get; set; }

    /// <summary>
    /// tài khoản giá vốn
    /// </summary>
    public string? AccountCostPrice { get; set; }

    /// <summary>
    /// tài khoản vật tư
    /// </summary>
    public string? AccountSupplies { get; set; }

    /// <summary>
    /// tài khoản chi phí nguyên vật liệu
    /// </summary>
    public string? AccountCostMaterials { get; set; }

    /// <summary>
    /// tài khoản dở dang
    /// </summary>
    public string? AccountIncomplete { get; set; }

    /// <summary>
    /// tiêm chủng
    /// </summary>
    public int? IsVaccination { get; set; }

    public virtual ICollection<AppointmentMedicalExamination> AppointmentMedicalExaminations { get; set; } = new List<AppointmentMedicalExamination>();

    public virtual ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();

    public virtual CategoryHospital? ClsImplementUnitMedical { get; set; }

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryGroupServiceLevel1 GroupServiceLvl1Navigation { get; set; } = null!;

    public virtual CategoryGroupServiceLevel2? GroupServiceLvl2Navigation { get; set; }

    public virtual CategoryGroupServiceLevel3? GroupServiceLvl3Navigation { get; set; }

    public virtual ICollection<MedicalExaminationServiceDepartmentAssign> MedicalExaminationServiceDepartmentAssigns { get; set; } = new List<MedicalExaminationServiceDepartmentAssign>();

    public virtual ICollection<MedicalExaminationServiceOtherSourcePay> MedicalExaminationServiceOtherSourcePays { get; set; } = new List<MedicalExaminationServiceOtherSourcePay>();

    public virtual ICollection<MedicalExaminationServiceServiceList> MedicalExaminationServiceServiceLists { get; set; } = new List<MedicalExaminationServiceServiceList>();

    public virtual ICollection<MedicalExaminationServiceSpecialist> MedicalExaminationServiceSpecialists { get; set; } = new List<MedicalExaminationServiceSpecialist>();

    public virtual ICollection<MedicalExaminationServiceTabAccompanyingService> MedicalExaminationServiceTabAccompanyingServices { get; set; } = new List<MedicalExaminationServiceTabAccompanyingService>();

    public virtual ICollection<MedicalExaminationServiceTabCostGroup> MedicalExaminationServiceTabCostGroups { get; set; } = new List<MedicalExaminationServiceTabCostGroup>();

    public virtual ICollection<MedicalExaminationServiceTabHistoryChange> MedicalExaminationServiceTabHistoryChanges { get; set; } = new List<MedicalExaminationServiceTabHistoryChange>();

    public virtual ICollection<MedicalExaminationServiceTabImplementationRoom> MedicalExaminationServiceTabImplementationRooms { get; set; } = new List<MedicalExaminationServiceTabImplementationRoom>();

    public virtual ICollection<MedicalExaminationServiceTabInsurancePaymentCondition> MedicalExaminationServiceTabInsurancePaymentConditions { get; set; } = new List<MedicalExaminationServiceTabInsurancePaymentCondition>();

    public virtual ICollection<MedicalExaminationServiceTabPriceOption> MedicalExaminationServiceTabPriceOptions { get; set; } = new List<MedicalExaminationServiceTabPriceOption>();

    public virtual CategorySpecialist? Specialist { get; set; }

    public virtual CategoryHospital? TechServiceTranferUnitMedical { get; set; }

    public virtual CategoryUnit? Unit { get; set; }
}
